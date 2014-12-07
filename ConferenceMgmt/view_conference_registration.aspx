<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_conference_registration.aspx.cs"
    Inherits="ConferenceMgmt.view_conference_registration" %>

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
            <div class="body_left">
                <div class="mn">
                    <strong style="color: #FFF;">Hello, User</strong></div>
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
                    <legend>Conference Registration<br>
                    </legend>
                    <form name="form1" method="post" action="">
                    <table width="70%" border="0" cellspacing="0" cellpadding="0" align="center" style="margin-top: 8px;
                        text-align: left;">
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Paper ID
                            </td>
                            <td width="78%">
                                <label>
                                    <txtpaperid>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                First Name
                            </td>
                            <td width="78%">
                                <label>
                                    <txtfirstname>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Last Name
                            </td>
                            <td width="78%">
                                <label>
                                    <txtlastname>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Institution
                            </td>
                            <td width="78%">
                                <label>
                                    <txtinstituition>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Email
                            </td>
                            <td width="78%">
                                <label>
                                    <txtemail>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Paper Topic
                            </td>
                            <td>
                                <label>
                                    <txtpapertopic>
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Activity
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Food
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Comments
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Fee Adjustment
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Fee Type
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Payment Status
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                    </form>
                    <div class="mn">
                        <a style="background: none; font-size: 16px; text-decoration: none; color: #FFF;"
                            href="payment.php?id=<?php echo $row_user['id']; ?>">Complete your payment please
                            Click Here(Please Check the Payment Status)</a></div>
                </fieldset>
            </div>
        </div>
    </div>
</body>
</html>
