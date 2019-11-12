﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewData("Title")</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-1.5.1.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/modernizr-1.7.min.js")" type="text/javascript"></script>
         <link href="@Url.Content("~/Content/themes/base/jquery.ui.core.css")" 
        rel="stylesheet" type="text/css" />
    <link href="@Url.Content("~/Content/themes/base/jquery.ui.datepicker.css")" 
        rel="stylesheet"  type="text/css" />
    <link href="@Url.Content("~/Content/themes/base/jquery.ui.theme.css")" 
        rel="stylesheet" type="text/css" />

    <script src="@Url.Content("~/Scripts/jquery.ui.core.min.js")" 
        type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.ui.datepicker.min.js")" 
        type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/DatePickerReady.js")" 
        type="text/javascript"></script>
</head>
<body>
    <div class="page">
        <header>
            <div id="title">
              <h1>Movie jQuery</h1>
            </div>
            <div id="logindisplay">
                 Log On
            </div>
            <nav>
                <ul id="menu">
                    <li>@Html.ActionLink("Home", "Index", "Movies")</li>
                    <li>@Html.ActionLink("About", "PersonDetail", "Movies")</li>
                </ul>
            </nav>
        </header>
        <section id="main">
            @RenderBody()
        </section>
        <footer>
        </footer>
    </div>
</body>
</html>
