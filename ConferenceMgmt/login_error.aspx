<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_error.aspx.cs" Inherits="ConferenceMgmt.login_error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Conference Registration Application </title>
    <link rel="stylesheet" href="StyleSheet1.css" type="text/css" />
</head>
<body>
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
            <div class="login_left">
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                    Insert a valid username and password to gain access to your profile.
                    <br />
                    <a href="signup.aspx"><strong style="text-decoration: none; color: #333">For Signup
                        click here</strong></a><br />
                </p>
            </div>
            <div class="login_right">
                <p>
                    &nbsp;</p>
                <fieldset>
                    <legend>Use Panel</legend>
                    <br>
                    <form name="form1" method="post" action="login_validation.aspx">
                    <p style="color: #F00">
                        Please Enter valid username and password</p>
                    <table width="70%" border="0" cellspacing="0" cellpadding="0" align="center" style="margin-top: 8px;">
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Username
                            </td>
                            <td width="78%">
                                <input name="username" type="text" id="username" />
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Password
                            </td>
                            <td>
                                <input name="password" type="password" id="name" />
                            </td>
                        </tr>
                        <tr>
                            <td width="22%" height="38">
                            </td>
                            <td>
                                <input style="width: 200px;" name="add" type="submit" class="btn" value="login" />
                            </td>
                        </tr>
                    </table>
                    </form>
                </fieldset>
            </div>
        </div>
    </div>
</body>
</html>
