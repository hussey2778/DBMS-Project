<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="ConferenceMgmt.Signup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!--
    Created by Artisteer v2.4.0.26594
    Base template (without user's data) checked by http://validator.w3.org : "This page is valid XHTML 1.0 Transitional"
    -->
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <title>TEAM 9</title>

    <link rel="stylesheet" href="style.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="style.ie6.css" type="text/css" media="screen" />
    
    <link rel="stylesheet" href="style.ie7.css" type="text/css" media="screen" />
    <%--<link rel="stylesheet" href="StyleSheet1.css" type="text/css" media="screen" />
    --%> 
    <script src="Scripts/jquery-1.11.0.min.js" type="text/javascript"></script
    <script src="Scripts/jquery-1.11.0.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.timepicker.js" type="text/javascript"></script>
    <script src="Scripts/bootstrap-datepicker.js" type="text/javascript"></script>
    <script src="Scripts/picker-site.js" type="text/javascript"></script>
    <link href="Styles/jquery.timepicker.css" rel="stylesheet" type="text/css" />
    <link href="Styles/bootstrap-datepicker.css" rel="stylesheet" type="text/css" />
    <link href="Styles/picker-site.css" rel="stylesheet" type="text/css" />
    <link href="Styles/picker-site.css" rel="stylesheet" type="text/css" />
  
    <script type="text/javascript" src="script.js"></script>
    </head>
<body>
                <div class="art-header">
                    <div class="art-header-png"></div>
                    <div class="art-header-jpeg"></div>
                    <div class="art-logo">
                        <h1 id="name-text" class="art-logo-name"><a href="#">Online Conference Management</a></h1>
                    </div>
                </div>

    <form id="form1" runat="server">
    <div id="main_body">
        <div class="head">
            <div class="header_left">
                
            <div class="header_right">
                <div class="header_right_text">
                </div>
            </div>
        </div>
        <div >
            <h1 class = "art-postheader" align = "centre" >
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Sign Up</h1>
           
                
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    If you are already registered please
                   
                    <a href="default.aspx">Click here for
                        log in</a>
                </p>
           
            <div class = "art-postcontent">
                <p>
                    &nbsp;</p>
                <fieldset>
                    <table width="95%" height="232" border="0" align="center" cellpadding="0" cellspacing="0"
                        style="margin-top: 8px; text-align: Centre;">
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                First Name
                            </td>
                            <td width="78%">
                                <asp:TextBox runat="server" Style="width: 200px;" ID="txtFirstName"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red"  runat="server" ControlToValidate="txtFirstName" Text="Required"
                                    Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Last Name
                            </td>
                            <td width="78%">
                                <asp:TextBox runat="server" Style="width: 200px;" ID="txtLastName"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red"  ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Password
                            </td>
                            <td>
                                <asp:TextBox runat="server" Style="width: 200px;" ID="txtPassword" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red"  ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Confirm Password
                            </td>
                            <td>
                                <asp:TextBox runat="server" Style="width: 200px;" TextMode="Password" ID="txtConfPassword"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red"  ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtConfPassword"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator><br />
                                <asp:CompareValidator  ForeColor="Red" runat="server" ControlToValidate="txtConfPassword" ControlToCompare="txtPassword"
                                    Text="Password doesn't match"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Institution
                            </td>
                            <td>
                                <asp:TextBox runat="server" Style="width: 200px;" ID="txtInstitution"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red"  ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtInstitution"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Email
                            </td>
                            <td>
                                <asp:TextBox runat="server" Style="width: 200px;" ID="txtEmail"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                Role
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlRole" Width="200px" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator3" runat="server" InitialValue="0" ControlToValidate="ddlRole"
                                    Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="22%" height="38">
                            </td>
                            <td>
                                <asp:Button Style="width: 200px;" class="btn" Text="Sign up" ID="btnSignup" runat="server"
                                    OnClick="btnSignup_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
