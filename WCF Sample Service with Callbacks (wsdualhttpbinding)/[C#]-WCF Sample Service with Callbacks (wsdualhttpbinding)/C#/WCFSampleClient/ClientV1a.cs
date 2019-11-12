﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using WCFSampleClient.DataServiceProxy;

namespace WCFSampleClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    class ClientV1a : IClient
    {
        // when the client is constructed
        private DateTime start = DateTime.Now;

        public void RunGetCustomer(int customerId)
        {            
            using (var client = new DataServiceClient("basic"))
            {
                var addressTask = Task.Factory.StartNew(() =>
                    {
                        var address = client.GetCustomerAddress(customerId);

                        if (Helper.ValidateCustomerAddress(customerId, address))
                            Console.WriteLine("RunTest {0} Address successful Elapsed={1}", customerId, DateTime.Now.Subtract(start).TotalMilliseconds);
                        else
                            Console.WriteLine("RunTest {0} Address failure Elapsed={1} **************", customerId, DateTime.Now.Subtract(start).TotalMilliseconds);
                    });

                var invoiceTask = Task.Factory.StartNew(() =>
                    {
                        var invoices = client.GetCustomerInvoices(customerId);

                        if (Helper.ValidateCustomerInvoices(customerId, invoices))
                            Console.WriteLine("RunTest {0} Invoices successful Elapsed={1}", customerId,
                                              DateTime.Now.Subtract(start).TotalMilliseconds);
                        else
                            Console.WriteLine("RunTest {0} Invoices failure Elapsed={1} **************", customerId,
                                              DateTime.Now.Subtract(start).TotalMilliseconds);

                    });


                var customerTask = Task.Factory.StartNew(() =>
                    {
                        var customer = client.GetCustomer(customerId);

                        if (Helper.ValidateCustomer(customerId, customer))
                            Console.WriteLine("RunTest {0} Customer successful Elapsed={1}", customerId,
                                              DateTime.Now.Subtract(start).TotalMilliseconds);
                        else
                            Console.WriteLine("RunTest {0} Customer failure Elapsed={1} **************", customerId,
                                              DateTime.Now.Subtract(start).TotalMilliseconds);
                    });

                customerTask.Wait();
                addressTask.Wait();
                invoiceTask.Wait();
            }
        }        
    }
}
