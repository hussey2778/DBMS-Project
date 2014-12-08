<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index_conference_registration.aspx.cs" Inherits="ConferenceMgmt.Index_conference_reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Conference Registration Application </title>
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
    <link href="App_Data/style.css" rel="stylesheet" type="text/css" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main_body">
        <div class="head">
            <div class="header_left">
                <div class="header_left_text">
                    Conference Registration WEB App</div>
            </div>
            <div class="header_right">
                <div class="header_right_text">
                </div>
            </div>
        </div>
        <div class="body_mid">
            <h1 style="background-color: #CCC;">
                Conference Registration</h1>
            <div class="body_left">
                <div class="mn">
                    <strong style="color: #FFF;">Hello, User </strong>
                </div>
                <div class="mn">
                    <a style="background: none; text-decoration: none; color: #FFF;" href="index_view.aspx">
                        View Profile</a></div>
                <div class="mn">
                    <a style="background: none; text-decoration: none; color: #FFF;" href="index_conference_registration.aspx">
                        Conference Registration</a></div>
                <div class="mn">
                    <a style="background: none; text-decoration: none; color: #FFF;" href="view_conference_registration.aspx">
                        View Registration</a></div>
                <div class="mn">
                    <a style="background: none; text-decoration: none; color: #FFF;" href="logout.aspx">
                        Log Out</a>
                </div>
            </div>
            <div class="body_mid_1">
                <p>
                    &nbsp;</p>
                <fieldset>
                    <legend>-----Profile Details<br>
                    </legend>
                    </div>
                    <table width="70%" border="0" cellspacing="0" cellpadding="0" align="centre" style="margin-top: 8px;
                        text-align: left;background-color:#CCC;">
                        <tr>
                            <td width="30%" style="font-size: 12px;" class="auto-style1">
                                Paper ID
                            </td>
                            <td width="78%" class="auto-style1">
                                <label id="txtPaperId">
                                    <literal id="txtPaperid">
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                First Name
                            </td>
                            <td width="78%">
                                <label>
                                    <literal id="txtFirstName">
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Last Name
                            </td>
                            <td width="78%">
                                <label>
                                    <literal id="txtLastName">
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Institution
                            </td>
                            <td>
                                <literal id="txtInstituition">
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Email
                            </td>
                            <td>
                                <literal id="txtEmail">
                            </td>
                        </tr>
                    </table>
                    
                </fieldset>
                <p>
                    &nbsp;</p>
                <fieldset>
                    <legend>Conference Registration Form<br>
                    </legend>
                    </fieldset><table width="95%" height="232" border="0" align="center" cellpadding="0" cellspacing="0"
                        style="margin-top: 8px; text-align: left;background-color:#CCC";>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Paper Topic
                            </td>
                            <td width="78%">
                                <input style="width: 200px;" name="txtPaperTopic" type="text" id="txtPaperTopic" runat ="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Activity
                            </td>
                            <td width="78%">
                                <select style="width: 200px;" name="activity" runat ="server" id="txtActivity">
                                    <option value="None">None</option>
                                    <option value="Banquet">Banquet</option>
                                    <option value="Symposium">Symposium</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Food
                            </td>
                            <td width="78%">
                                <select style="width: 200px;" name="food" runat ="server" id="txtFood">
                                    <option value="None">None</option>
                                    <option value="Vegetarian  ">Vegetarian </option>
                                    <option value="Non-Vegetarian">Non-Vegetarian </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%">
                                <input type="checkbox" name="txtTutorial" id="Tut" onclick="javascript:" />
                                Register for Tutorial
                            </td>
                        </tr>
                        <script>
                            $(document).ready(function () {
                                $('#Tut').check(function () {
                                    $('#p').show();
                                });
                            });
                        </script>
                        <p>
                            <tr>
                                <td width="30%" height="38" style="font-size: 12px;">
                                    Tutorial Name
                                </td>
                                <td width="78%">
                                    &nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="58px" Width="195px"></asp:ListBox>
                                </td>
                            </tr>
                             <tr>
                                <td width="30%" height="38" style="font-size: 12px;">
                                    Tutorial Id
                                </td>
                                <td width="78%">
                                    <input style="width: 200px;" name="txtTutorialId" type="text" id="txtTutorialId" />
                                </td>
                            </tr>
                            <tr>
                                <td width="30%" height="38" style="font-size: 12px;">
                                    Tutorial Fee
                                </td>
                                <td width="78%">
                                    <input style="width: 200px;" name="txtTutorialFee" type="text" id="TxtTutorialFee" />
                                </td>
                            </tr>
                        </p>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Comments
                            </td>
                            <td>
                                <textarea name="comments" id="txtComment" style="width: 200px;"></textarea>
                            </td>
                        </tr>
                        <%-- <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Fee Adjustment
                            </td>
                            <td width="78%">
                                <select style="width: 200px;" name="fee_adjustment">
                                    <option value="Early">Early</option>
                                    <option value="Normal  ">Normal </option>
                                    <option value="Onsite Registration">Onsite Registration </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Fee Type
                            </td>
                            <td width="78%">
                                <select style="width: 200px;" name="fee_type">
                                    <option value="Student">Student</option>
                                    <option value="Regular  ">Regular </option>
                                    <option value="Special">Special </option>
                                </select>
                            </td>
                        </tr>--%>
                        <tr>
                            <td width="78%">
                                <input name="id" type="hidden" value="txtId" />
                            </td>
                        </tr>
                        <tr>
                            <td width="78%">
                                <input name="f_name" type="hidden" value="txtFirstName" />
                            </td>
                        </tr>
                            <tr>
                                <td width="78%">
                                    <input name="l_name" type="hidden" value="txtLastName" />
                                </td>
                            </tr>
                            <tr>
                                <td width="78%">
                                    <input name="institution" type="hidden" value="txtInstituition" />
                                </td>
                            </tr>
                            <tr>
                                <td width="78%">
                                    <input name="email" type="hidden" value="txtEmail" />
                                </td>
                            </tr>
                            <tr>
                                <td width="78%">
                                    <input name="payment" type="hidden" value="txtUnpaid" />
                                </td>
                            </tr>
                            <tr>
                                <td width="22%" height="38">
                                </td>
                                <td>
                                    <asp:Button ID="btnSubmit" Style="width: 200px;" runat="server" class="btn" Text="Submit"
                                        OnClick="btnSubmit_Click" />
                                    <%--<input style="width: 200px;" name="btnSubmit" type="button" runat="server" class="btn" value="Make Payment" onclick="btnSubmit_Click" />--%>
                                </td>
                            </tr>
                    </table>
                    </form>
                </fieldset>
            </div>
        </div>
    </div>
        </form>
</body>
</html>
