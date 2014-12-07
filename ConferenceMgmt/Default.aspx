<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConferenceMgmt.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
                      <head>
                          <style type="text/css">
                              .style1
                              {
                                  width: 49%;
                              }
                          </style>
                      </head>
                      <body background="images\login_bck.jpg">
                      <form runat = "server">
                      <div class="login_left">
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                          <p>
                              &nbsp;</p>
                          <p>
                              &nbsp;</p>
                <p>
                <td width="30%" height="38" style="font-size: 25px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Sign in to continue to TEAM 9 Online Conference System</td></br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <a href="signup.aspx"><strong style="text-decoration: none; color: #333">Join Now!</strong></a>&nbsp;</p>
                          <p>
                              &nbsp;</p>
            </div>
                      
                    <table border="0" cellspacing="0" cellpadding="0" align="center" 
                          style="margin-top: 8px; width: 42%;">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblError" runat="server" Text="Invalid email or password" ForeColor="Red" Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 18px;">
                                Email
                            </td>
                            <td class="style1">
                                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator6" runat="server"
                                    ControlToValidate="txtEmail" Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 18px;">
                                Password
                            </td>
                            <td class="style1">
                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Width="138px"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="txtPassword" Text="Required" Display="Dynamic"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td width="22%" height="38">
                            </td>
                            <td class="style1">
                                <asp:Button class="btn" Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click">
                                </asp:Button>
                            </td>
                        </tr>
                    </table>
                    </form>
</body>
</html>
