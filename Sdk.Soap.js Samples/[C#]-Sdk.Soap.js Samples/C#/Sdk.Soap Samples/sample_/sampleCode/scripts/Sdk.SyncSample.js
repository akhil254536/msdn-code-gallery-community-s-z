﻿// =====================================================================
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
// =====================================================================
/// <reference path="../../vsdoc/Sdk.Soap.vsdoc.js" />
/// <reference path="../../vsdoc/messages/Sdk.SetState.vsdoc.js" />
/// <reference path="../../vsdoc/entities/Sdk.Account.vsdoc.js" />
/// <reference path="../../vsdoc/entities/Sdk.Opportunity.vsdoc.js" />
/// <reference path="../../vsdoc/entities/Sdk.Task.vsdoc.js" />

// Variables to cache created records for deletion later
var createdAccountId, createdOpportunityId, createdTaskId, taskCollection;

var accountColumnset = new Sdk.ColumnSet(
 "creditonhold",
 "address1_latitude",
 "address1_longitude",
 "numberofemployees",
 "description",
 "name",
 "creditlimit",
 "accountcategorycode",
 "versionnumber",
 "donotbulkemail",
 "createdon",
 "createdby",
 "exchangerate",
 "sharesoutstanding",
 "owninguser",
 "revenue",
 "ownerid",
 "industrycode",
 "statecode",
 "statuscode",
 "accountnumber",
 "address1_addressid",
 "address1_city",
 "accountid");

function startEarlyBindingSample() {
 writeToPage("Starting sample by creating account.");
 //Instantiate an account using Sdk.Entity:
 var account = new Sdk.Account();
 account.Name.setValue("Sample Account 001");
 account.CreditOnHold.setValue(false);
 account.Address1_Latitude.setValue(47.638197);
 account.Address1_Longitude.setValue(-122.131378);
 account.NumberOfEmployees.setValue(100000);
 account.Description.setValue("This is a description. \n It has several lines. \n This is the third line.");
 account.CreditLimit.setValue(2000000.00);
 account.AccountCategoryCode.setValue(1) //Preferred Customer
 try {
  // Call create
  createdAccountId = Sdk.Sync.create(account);
  writeToPage("Created account with id: " + createdAccountId);
 }
 catch (e) {
  throw new Error("Error on Create account: " + e.message);
 }
 // Retrieve the account created:
 try {
  account = new Sdk.Account(Sdk.Sync.retrieve("account", createdAccountId, accountColumnset));
  writeToPage("Retrieved account named: " + account.Name.getValue());
 }
 catch (e) {
  throw new Error("Error Retrieving Account: " + e.message);
 }
 // Update the retrieved account
 account.SharesOutstanding.setValue(200);
 account.Revenue.setValue(3000000.00);
 account.IndustryCode.setValue(6); //Business Services
 account.AccountNumber.setValue("ABC123");
 try {
  Sdk.Sync.update(account);
  writeToPage("Updated account");
 }
 catch (e) {
  throw new Error("Error on update Account: " + e.message);
 }
 try {
  //Call retrieve again to refresh formatted values:
  account = new Sdk.Account(Sdk.Sync.retrieve("account", createdAccountId, accountColumnset));
  writeToPage("Retrieved account after updating to get any new formatted values");
 }
 catch (e) {
  throw new Error("Error on second retrieve Account: " + e.message);
 }

 writeToPage("These are the current values for the account:");
 showEntityAttributeValues(account);

 //Create Opportunity with Task:
 var opportunity = new Sdk.Opportunity();
 opportunity.Name.setValue("Sample Opportunity 001");
 opportunity.CustomerId.setValue(account.toEntityReference());

 var task = new Sdk.Task();
 task.Subject.setValue("Sample Task 001");
 var dueDate = new Date();
 dueDate.setDate(dueDate.getDate() + 10);
 task.ScheduledEnd.setValue(dueDate);
 //Adding the task to the related Opportunity_Tasks before create
 // will associate the task with the opportunity when they are both created.
 //Note the use of the Sdk.Opportunity.OneToMany dictionary to set the relationship name,
 // this could be replaced with the simple string: "Opportunity_Tasks".
 opportunity.addRelatedEntity(Sdk.Opportunity.OneToMany.Opportunity_Tasks, task);
 try {
  createdOpportunityId = Sdk.Sync.create(opportunity);
  writeToPage("Created new Opportunity with id:" + createdOpportunityId);
 }
 catch (e) {
  throw new Error("Error on Opportunity create: " + e.message);
 }

 //Retrieve the task created with the opportunity by querying tasks related to the opportunity
 var retrieveTasksQuery = new Sdk.Query.QueryByAttribute("task");
 retrieveTasksQuery.setColumnSet("subject", "scheduledend", "regardingobjectid");
 retrieveTasksQuery.addAttributeValue(new Sdk.Lookup("regardingobjectid", new Sdk.EntityReference("opportunity", createdOpportunityId)));
 try {
 taskCollection = Sdk.Sync.retrieveMultiple(retrieveTasksQuery);
  writeToPage("Retrieved " + taskCollection.getCount() + " task");
 }
 catch (e) {
  throw new Error("Error on retrieving tasks related to opportunity: " + e.message);
 }

 writeToPage("These are the properties of the task retrieved:");
 var task = new Sdk.Task(taskCollection.getEntity(0));
 createdTaskId = task.getId(); //cache for deletion later
 showEntityAttributeValues(task);

 var setStateRequest = new Sdk.SetStateRequest(task.toEntityReference(), 1, 5); //Completed, Completed
 try {
  Sdk.Sync.execute(setStateRequest);
  writeToPage("Task set to Completed.");
 }
 catch (e) {
  throw new Error("Error on completeing Task using SetStateRequest: " + e.message);
 }


 try {
  Sdk.Sync.del("task", createdTaskId);
  writeToPage("Task Deleted");
 }
 catch (e) {
  throw new Error("Error on deleting Task: " + e.message);
 }

 try {
  Sdk.Sync.del("opportunity", createdOpportunityId);
  writeToPage("Opportunity Deleted");
 }
 catch (e) {
  throw new Error("Error on deleting Opportunity: " + e.message);
 }

 try {
  Sdk.Sync.del("account", createdAccountId);
  writeToPage("Ending sample by deleting account.");
 }
 catch (e) {
  throw new Error("Error on deleting Account: " + e.message);
 }


}

//This dictionary of columns is used by 
// the initializeEntity and getColumnSet functions
// with 'late-binding' style.
var accountColumns = {
 "creditonhold": Sdk.Boolean,
 "address1_latitude": Sdk.Double,
 "address1_longitude": Sdk.Double,
 "numberofemployees": Sdk.Int,
 "description": Sdk.String,
 "name": Sdk.String,
 "creditlimit": Sdk.Money,
 "accountcategorycode": Sdk.OptionSet,
 "versionnumber": Sdk.Long,
 "donotbulkemail": Sdk.Boolean,
 "createdon": Sdk.DateTime,
 "createdby": Sdk.Lookup,
 "exchangerate": Sdk.Decimal,
 "sharesoutstanding": Sdk.Int,
 "owninguser": Sdk.Lookup,
 "revenue": Sdk.Money,
 "ownerid": Sdk.Lookup,
 "industrycode": Sdk.OptionSet,
 "statecode": Sdk.OptionSet,
 "statuscode": Sdk.OptionSet,
 "accountnumber": Sdk.String,
 "address1_addressid": Sdk.Guid,
 "address1_city": Sdk.String,
 "accountid": Sdk.Guid
};



function startLateBindingSample() {
 writeToPage("Starting sample by creating account.");

 //Instantiate an account using Sdk.Entity:
 var account = new Sdk.Entity("account");
 //When using 'late-binding' a helper function like initializeEntity helps simplify syntax to set values.
 //You will want to use this everytime you retrieve a record too.
 initializeEntity(account, accountColumns);
 account.setValue("name", "Sample Account 001");
 account.setValue("creditonhold", false);
 account.setValue("address1_latitude", 47.638197);
 account.setValue("address1_longitude", -122.131378);
 account.setValue("numberofemployees", 100000);
 account.setValue("description", "This is a description. \n It has several lines. \n This is the third line.");
 account.setValue("creditlimit", 2000000.00);
 account.setValue("accountcategorycode", 1); //Preferred Customer
 //Without initializeEntity:
 //account.addAttribute(new Sdk.String("name", name));
 //account.addAttribute(new Sdk.Boolean("creditonhold", false));
 //account.addAttribute(new Sdk.Double("address1_latitude", 47.638197));
 //account.addAttribute(new Sdk.Double("address1_longitude", -122.131378));
 //account.addAttribute(new Sdk.Int("numberofemployees", 100000));
 //account.addAttribute(new Sdk.String("description", "This is a description. \n It has several lines. \n This is the third line."));
 //account.addAttribute(new Sdk.Money("creditlimit", 2000000));
 //account.addAttribute(new Sdk.OptionSet("accountcategorycode", 1)); //Preferred Customer

 try {
  createdAccountId = Sdk.Sync.create(account);
  writeToPage("Created account with id: " + createdAccountId);
 }
 catch (e) {
  throw new Error("Error on Create account: " + e.message);
 }
 // Retrieve the account created:
 try {

  account = Sdk.Sync.retrieve("account", createdAccountId, getColumnSet(accountColumns));
  initializeEntity(account, accountColumns);
  writeToPage("Retrieved account named: " + account.getValue("name"));
 }
 catch (e) {
  throw new Error("Error Retrieving Account: " + e.message);
 }
 // Update the retrieved account
 account.setValue("sharesoutstanding", 200);
 account.setValue("revenue", 3000000.00);
 account.setValue("industrycode", 6); //Business Services
 account.setValue("accountnumber", "ABC123");

 try {
  Sdk.Sync.update(account);
  writeToPage("Updated account");
 }
 catch (e) {
  throw new Error("Error on update Account: " + e.message);
 }
 try {
  //Call retrieve again to refresh formatted values:
  account = Sdk.Sync.retrieve("account", createdAccountId, getColumnSet(accountColumns));
  initializeEntity(account, accountColumns);
  writeToPage("Retrieved account after updating to get any new formatted values");
 }
 catch (e) {
  throw new Error("Error on second retrieve Account: " + e.message);
 }
 writeToPage("These are the current values for the account:");
 showEntityAttributeValues(account);

 //Create Opportunity with Task:
 var opportunity = new Sdk.Entity("opportunity");
 opportunity.addAttribute(new Sdk.String("name", "Sample Opportunity 001"));
 opportunity.addAttribute(new Sdk.Lookup("customerid", account.toEntityReference()));

 var task = new Sdk.Entity("task");
 task.addAttribute(new Sdk.String("subject", "Sample Task 001"));
 //Set due date 10 days into the future:
 var dueDate = new Date();
 dueDate.setDate(dueDate.getDate() + 10);
 task.addAttribute(new Sdk.DateTime("scheduledend", dueDate));
 //Adding the task to the related Opportunity_Tasks before create
 // will associate the task with the opportunity when they are both created.
 opportunity.addRelatedEntity("Opportunity_Tasks", task);

 try {
  createdOpportunityId = Sdk.Sync.create(opportunity);
  writeToPage("Created new Opportunity with id:" + createdOpportunityId);
 }
 catch (e) {
  throw new Error("Error on Opportunity create: " + e.message);
 }

 //Retrieve the task created with the opportunity by querying tasks related to the opportunity
 var retrieveTasksQuery = new Sdk.Query.QueryByAttribute("task");
 retrieveTasksQuery.setColumnSet("subject", "scheduledend", "regardingobjectid");
 retrieveTasksQuery.addAttributeValue(new Sdk.Lookup("regardingobjectid", new Sdk.EntityReference("opportunity", createdOpportunityId)));
 try {
  taskCollection = Sdk.Sync.retrieveMultiple(retrieveTasksQuery);
  writeToPage("Retrieved " + taskCollection.getCount() + " task");
 }
 catch (e) {
  throw new Error("Error on retrieving tasks related to opportunity: " + e.message);
 }

 writeToPage("These are the properties of the task retrieved:");
 var task = taskCollection.getEntity(0);
 createdTaskId = task.getId(); //cache for deletion later
 showEntityAttributeValues(task);
 //Complete the task using SetStateRequest message
 var setStateRequest = new Sdk.SetStateRequest(task.toEntityReference(), 1, 5); //Completed, Completed
 try {
  Sdk.Sync.execute(setStateRequest);
  writeToPage("Task set to Completed.");
 }
 catch (e) {
  throw new Error("Error on completeing Task using SetStateRequest: " + e.message);
 }

 try {
  Sdk.Sync.del("task", createdTaskId);
  writeToPage("Task Deleted");
 }
 catch (e) {
  throw new Error("Error on deleting Task: " + e.message);
 }

 try {
  Sdk.Sync.del("opportunity", createdOpportunityId);
  writeToPage("Opportunity Deleted");
 }
 catch (e) {
  throw new Error("Error on deleting Opportunity: " + e.message);
 }

 try {
  Sdk.Sync.del("account", createdAccountId);
  writeToPage("Ending sample by deleting account.");
 }
 catch (e) {
  throw new Error("Error on deleting Account: " + e.message);
 }


}

function initializeEntity(entity, columns) {
 for (var i in columns) {
  entity.addAttribute(new columns[i](i));
 }
}

function getColumnSet(entityColumns) {
 var attributeNames = [];
 for (var i in entityColumns) {
  attributeNames.push(i);
 }
 //Sdk.ColumnSet accepts an array of strings as the parameter.
 return new Sdk.ColumnSet(attributeNames);
}

function showEntityAttributeValues(entity) {
 var table = document.createElement("table");
 addRowToTable("th", "Property", "Value");
 entity.getAttributes().forEach(function (a, i) {
  var type = a.getType();
  var name = a.getName();
  var value = "null";
  switch (type) {
   case Sdk.ValueType.entityReference:
    if (entity.getValue(name) != null) {
     value = (entity.getValue(name).getName() == null) ? entity.getValue(name).getId() : entity.getValue(name).getName();
    }
    break;
    //show formatted values
   case Sdk.ValueType.boolean:
   case Sdk.ValueType.money:
   case Sdk.ValueType.optionSet:
    value = (entity.getValue(name) == null) ? "null" : entity.getFormattedValues().getItem(name).getValue();
    break;
   default:
    value = (entity.getValue(a.getName()) == null) ? "null" : entity.getValue(a.getName()).toString();
    break;
  }
  addRowToTable("td", name, value);
 });

 writeToPage(table);

 function addRowToTable(tagName, propertyName, value) {

  var row = document.createElement("tr");
  var propertyCell = document.createElement(tagName);
  propertyCell.appendChild(document.createTextNode(propertyName));
  row.appendChild(propertyCell)
  var valueCell = document.createElement(tagName);
  valueCell.appendChild(document.createTextNode(value));
  row.appendChild(valueCell)
  table.appendChild(row);
 }
}

function writeToPage(message) {
 var messagesList = document.getElementById("messages");
 if (typeof message == "string") {
  var listItem = document.createElement("li");
  listItem.appendChild(document.createTextNode(message));
  messagesList.appendChild(listItem);
  return;
 }
 if (typeof message == "object" &&
  message != null &&
  message.nodeType == 1 &&
  typeof message.nodeName == "string") {
  messagesList.appendChild(message);
  return;
 }
 throw new Error("message parameter to writeToPage is not a string or DOM element");

}