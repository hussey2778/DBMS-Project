<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ConferenceMgmt.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main_body">
        <div class="head">
            <div class="header_left">
                <div class="header_left_text">
                    Conference Management System</div>
            </div>
            <div class="header_right">
                <div class="header_right_text">
                </div>
            </div>
        </div>
        <div class="body_mid">
            <h1 style="background-color: #CCC;">
                Conference Registration</h1>
            <div class="login_left">
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                    Insert a valid username and password to gain access to your profile.
                    <br />
                    <a href="signup.aspx"><strong style="text-decoration: none; color: #333">For Signup click
                        here</strong></a><br />
                </p>
            </div>
            <div class="login_right">
                <p>
                    &nbsp;</p>
                <fieldset>
                    <legend>Log in</legend>
                    <br>
                    <form name="form1" method="post" >
                    <table width="70%" border="0" cellspacing="0" cellpadding="0" align="center" style="margin-top: 8px;">
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Username
                            </td>
                            <td width="78%">
                                <input name="username" type="text" id="username" runat ="server" />
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Password
                            </td>
                            <td>
                                <input name="password" type="password" id="name" runat ="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input name="log" type="hidden" value="" />
                            </td>
                        </tr>
                        <tr>
                            <td width="22%" height="38">
                            </td>
                            <td>
                                <input style="width: 200px;" name="txtLogin" runat ="server" type="submit" class="btn" value="login" id="Submit1" />
                            </td>
                        </tr>
                    </table>
                    </form>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
