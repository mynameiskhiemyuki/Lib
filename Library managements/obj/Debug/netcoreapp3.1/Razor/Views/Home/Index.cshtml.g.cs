#pragma checksum "C:\Users\mynam\source\repos\Library managements\Library managements\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b78fe384aeaf3c8006ea7afab21b918d0c6761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mynam\source\repos\Library managements\Library managements\Views\_ViewImports.cshtml"
using Library_managements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mynam\source\repos\Library managements\Library managements\Views\_ViewImports.cshtml"
using Library_managements.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b78fe384aeaf3c8006ea7afab21b918d0c6761", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e07fb3a4083369c879e2f4e40a124d9857544", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("au-form-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mynam\source\repos\Library managements\Library managements\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- MAIN CONTENT-->
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""overview-wrap"">
                        <h2 class=""title-1"">overview</h2>
                        <button class=""au-btn au-btn-icon au-btn--blue"">
                            <i class=""zmdi zmdi-plus""></i>add item
                        </button>
                    </div>
                </div>
            </div>
            <div class=""row m-t-25"">
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c1"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-account-o""></i>
                                </div>
       ");
            WriteLiteral(@"                         <div class=""text"">
                                    <h2>10368</h2>
                                    <span>members online</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart1""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c2"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-shopping-cart""></i>
                                </div>
                                <div class=""text"">
                                    <h2>388,688</h2>
                            ");
            WriteLiteral(@"        <span>items solid</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart2""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c3"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-calendar-note""></i>
                                </div>
                                <div class=""text"">
                                    <h2>1,086</h2>
                                    <span>this week</span>
                                </div>
                            </div>
                      ");
            WriteLiteral(@"      <div class=""overview-chart"">
                                <canvas id=""widgetChart3""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-6 col-lg-3"">
                    <div class=""overview-item overview-item--c4"">
                        <div class=""overview__inner"">
                            <div class=""overview-box clearfix"">
                                <div class=""icon"">
                                    <i class=""zmdi zmdi-money""></i>
                                </div>
                                <div class=""text"">
                                    <h2>$1,060,386</h2>
                                    <span>total earnings</span>
                                </div>
                            </div>
                            <div class=""overview-chart"">
                                <canvas id=""widgetChart4""></canvas>
                         ");
            WriteLiteral(@"   </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""au-card recent-report"">
                        <div class=""au-card-inner"">
                            <h3 class=""title-2"">recent reports</h3>
                            <div class=""chart-info"">
                                <div class=""chart-info__left"">
                                    <div class=""chart-note"">
                                        <span class=""dot dot--blue""></span>
                                        <span>products</span>
                                    </div>
                                    <div class=""chart-note mr-0"">
                                        <span class=""dot dot--green""></span>
                                        <span>services</span>
                                    </div>
                                </div>
   ");
            WriteLiteral(@"                             <div class=""chart-info__right"">
                                    <div class=""chart-statis"">
                                        <span class=""index incre"">
                                            <i class=""zmdi zmdi-long-arrow-up""></i>25%
                                        </span>
                                        <span class=""label"">products</span>
                                    </div>
                                    <div class=""chart-statis mr-0"">
                                        <span class=""index decre"">
                                            <i class=""zmdi zmdi-long-arrow-down""></i>10%
                                        </span>
                                        <span class=""label"">services</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""recent-report__chart"">
                                <ca");
            WriteLiteral(@"nvas id=""recent-rep-chart""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""au-card chart-percent-card"">
                        <div class=""au-card-inner"">
                            <h3 class=""title-2 tm-b-5"">char by %</h3>
                            <div class=""row no-gutters"">
                                <div class=""col-xl-6"">
                                    <div class=""chart-note-wrap"">
                                        <div class=""chart-note mr-0 d-block"">
                                            <span class=""dot dot--blue""></span>
                                            <span>products</span>
                                        </div>
                                        <div class=""chart-note mr-0 d-block"">
                                            <span class=""dot dot--red""></span>
                         ");
            WriteLiteral(@"                   <span>services</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-xl-6"">
                                    <div class=""percent-chart"">
                                        <canvas id=""percent-chart""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-9"">
                    <h2 class=""title-1 m-b-25"">Earnings By Items</h2>
                    <div class=""table-responsive table--no-card m-b-40"">
                        <table class=""table table-borderless table-striped table-earning"">
                            <thead>
                                <tr>
                                    <th>date");
            WriteLiteral(@"</th>
                                    <th>order ID</th>
                                    <th>name</th>
                                    <th class=""text-right"">price</th>
                                    <th class=""text-right"">quantity</th>
                                    <th class=""text-right"">total</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>2018-09-29 05:57</td>
                                    <td>100398</td>
                                    <td>iPhone X 64Gb Grey</td>
                                    <td class=""text-right"">$999.00</td>
                                    <td class=""text-right"">1</td>
                                    <td class=""text-right"">$999.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-28 01:22</td>
         ");
            WriteLiteral(@"                           <td>100397</td>
                                    <td>Samsung S8 Black</td>
                                    <td class=""text-right"">$756.00</td>
                                    <td class=""text-right"">1</td>
                                    <td class=""text-right"">$756.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-27 02:12</td>
                                    <td>100396</td>
                                    <td>Game Console Controller</td>
                                    <td class=""text-right"">$22.00</td>
                                    <td class=""text-right"">2</td>
                                    <td class=""text-right"">$44.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-26 23:06</td>
                                    <td>100395</td>
                                    <");
            WriteLiteral(@"td>iPhone X 256Gb Black</td>
                                    <td class=""text-right"">$1199.00</td>
                                    <td class=""text-right"">1</td>
                                    <td class=""text-right"">$1199.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-25 19:03</td>
                                    <td>100393</td>
                                    <td>USB 3.0 Cable</td>
                                    <td class=""text-right"">$10.00</td>
                                    <td class=""text-right"">3</td>
                                    <td class=""text-right"">$30.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-29 05:57</td>
                                    <td>100392</td>
                                    <td>Smartwatch 4.0 LTE Wifi</td>
                                    <td class=""text-");
            WriteLiteral(@"right"">$199.00</td>
                                    <td class=""text-right"">6</td>
                                    <td class=""text-right"">$1494.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-24 19:10</td>
                                    <td>100391</td>
                                    <td>Camera C430W 4k</td>
                                    <td class=""text-right"">$699.00</td>
                                    <td class=""text-right"">1</td>
                                    <td class=""text-right"">$699.00</td>
                                </tr>
                                <tr>
                                    <td>2018-09-22 00:43</td>
                                    <td>100393</td>
                                    <td>USB 3.0 Cable</td>
                                    <td class=""text-right"">$10.00</td>
                                    <td class=""text-right"">3</td>
  ");
            WriteLiteral(@"                                  <td class=""text-right"">$30.00</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <h2 class=""title-1 m-b-25"">Top countries</h2>
                    <div class=""au-card au-card--bg-blue au-card-top-countries m-b-40"">
                        <div class=""au-card-inner"">
                            <div class=""table-responsive"">
                                <table class=""table table-top-countries"">
                                    <tbody>
                                        <tr>
                                            <td>United States</td>
                                            <td class=""text-right"">$119,366.96</td>
                                        </tr>
                                        <tr>
                                            <td>Australia</td>
      ");
            WriteLiteral(@"                                      <td class=""text-right"">$70,261.65</td>
                                        </tr>
                                        <tr>
                                            <td>United Kingdom</td>
                                            <td class=""text-right"">$46,399.22</td>
                                        </tr>
                                        <tr>
                                            <td>Turkey</td>
                                            <td class=""text-right"">$35,364.90</td>
                                        </tr>
                                        <tr>
                                            <td>Germany</td>
                                            <td class=""text-right"">$20,366.96</td>
                                        </tr>
                                        <tr>
                                            <td>France</td>
                                            <td class=""text-right"">$1");
            WriteLiteral(@"0,366.96</td>
                                        </tr>
                                        <tr>
                                            <td>Australia</td>
                                            <td class=""text-right"">$5,366.96</td>
                                        </tr>
                                        <tr>
                                            <td>Italy</td>
                                            <td class=""text-right"">$1639.32</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""au-card au-card--no-shadow au-card--no-pad m-b-40"">
                        <div class=""au-card-title"" style=""background-image:url('images/bg-title-01.jpg'");
            WriteLiteral(@");"">
                            <div class=""bg-overlay bg-overlay--blue""></div>
                            <h3>
                                <i class=""zmdi zmdi-account-calendar""></i>26 April, 2018
                            </h3>
                            <button class=""au-btn-plus"">
                                <i class=""zmdi zmdi-plus""></i>
                            </button>
                        </div>
                        <div class=""au-task js-list-load"">
                            <div class=""au-task__title"">
                                <p>Tasks for John Doe</p>
                            </div>
                            <div class=""au-task-list js-scrollbar3"">
                                <div class=""au-task__item au-task__item--danger"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Meeting about plan for Admin Template");
            WriteLiteral(@" 2018</a>
                                        </h5>
                                        <span class=""time"">10:00 AM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--warning"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">11:00 AM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--primary"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Meeting about plan for A");
            WriteLiteral(@"dmin Template 2018</a>
                                        </h5>
                                        <span class=""time"">02:00 PM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--success"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">03:30 PM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--danger js-load-item"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#""");
            WriteLiteral(@">Meeting about plan for Admin Template 2018</a>
                                        </h5>
                                        <span class=""time"">10:00 AM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--warning js-load-item"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">11:00 AM</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""au-task__footer"">
                                <button class=""au-btn au-btn-load js-load-btn"">load more</button>
                            </div>
             ");
            WriteLiteral(@"           </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""au-card au-card--no-shadow au-card--no-pad m-b-40"">
                        <div class=""au-card-title"" style=""background-image:url('images/bg-title-02.jpg');"">
                            <div class=""bg-overlay bg-overlay--blue""></div>
                            <h3>
                                <i class=""zmdi zmdi-comment-text""></i>New Messages
                            </h3>
                            <button class=""au-btn-plus"">
                                <i class=""zmdi zmdi-plus""></i>
                            </button>
                        </div>
                        <div class=""au-inbox-wrap js-inbox-wrap"">
                            <div class=""au-message js-list-load"">
                                <div class=""au-message__noti"">
                                    <p>
                                        You Have
       ");
            WriteLiteral(@"                                 <span>2</span>

                                        new messages
                                    </p>
                                </div>
                                <div class=""au-message-list"">
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">John Smith</h5>
         ");
            WriteLiteral(@"                                           <p>Have sent a photo</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>12 Min ago</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-03.jpg"" alt=""Nicholas Martinez"">
                                        ");
            WriteLiteral(@"            </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Nicholas Martinez</h5>
                                                    <p>You are now connected on message</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>11:00 PM</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""ava");
            WriteLiteral(@"tar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum dolor sit amet</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-");
            WriteLiteral(@"message__item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                        ");
            WriteLiteral(@"        <span>Sunday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum ");
            WriteLiteral(@"dolor sit amet</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                   ");
            WriteLiteral(@"             </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Sunday</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""au-message__footer"">
                                    <button class=""au-btn au-btn-load js-load-btn"">load more</button>
                                </div>
                            </div>
                            <div class=""au-chat"">
                          ");
            WriteLiteral(@"      <div class=""au-chat__title"">
                                    <div class=""au-chat-info"">
                                        <div class=""avatar-wrap online"">
                                            <div class=""avatar avatar--small"">
                                                <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                            </div>
                                        </div>
                                        <span class=""nick"">
                                            <a href=""#"">John Smith</a>
                                        </span>
                                    </div>
                                </div>
                                <div class=""au-chat__content"">
                                    <div class=""recei-mess-wrap"">
                                        <span class=""mess-time"">12 Min ago</span>
                                        <div class=""recei-mess__inner"">
             ");
            WriteLiteral(@"                               <div class=""avatar avatar--tiny"">
                                                <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                            </div>
                                            <div class=""recei-mess-list"">
                                                <div class=""recei-mess"">Lorem ipsum dolor sit amet, consectetur adipiscing elit non iaculis</div>
                                                <div class=""recei-mess"">Donec tempor, sapien ac viverra</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""send-mess-wrap"">
                                        <span class=""mess-time"">30 Sec ago</span>
                                        <div class=""send-mess__inner"">
                                            <div class=""send-mess-list"">
                              ");
            WriteLiteral(@"                  <div class=""send-mess"">Lorem ipsum dolor sit amet, consectetur adipiscing elit non iaculis</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""au-chat-textfield"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66b78fe384aeaf3c8006ea7afab21b918d0c676136457", async() => {
                WriteLiteral(@"
                                        <input class=""au-input au-input--full au-input--h65"" type=""text"" placeholder=""Type a message"">
                                        <button class=""au-input-icon"">
                                            <i class=""zmdi zmdi-camera""></i>
                                        </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""copyright"">
                        <p>Copyright © 2018 Colorlib. All rights reserved. Template by <a href=""https://colorlib.com"">Colorlib</a>.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- END MAIN CONTENT-->
<!-- END PAGE CONTAINER-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
