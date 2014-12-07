<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index_tutorial_registration.aspx.cs" Inherits="ConferenceMgmt.index_tutorial_registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="Scripts/jquery-1.11.0.min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">

        $(document).ready(function () {

            $('input:checkbox[id*=cbSelectTutorial]').click(function () {
                var $tr = $(this).closest('tr');
                var tutorialFees = $tr.find("input:hidden[name$=hdnTutorialFees]").val();
                var total = parseFloat($("#txtTotalFees").val());
                if ($(this).is(':checked')) {
                    total = total + parseFloat(tutorialFees);
                }
                else {
                    total = total - parseFloat(tutorialFees);
                }
                $("#txtTotalFees").val(total);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>
                Tutorials
            </td>
            <td>
                <asp:GridView ID="grvTutorials" AutoGenerateColumns="false" 
                    runat="server" DataKeyNames="TutorialID">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox name="cbSelectTutorial" ID="cbSelectTutorial" runat="server" />
                                <asp:HiddenField ID="hdnTutorialFees" runat="server" Value='<%# Eval("TutorialFees") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="TutorialName" HeaderText="Tutorial" />
                        <asp:BoundField DataField="TutorialDate" HeaderText="Date" />
                        <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
                        <asp:BoundField DataField="EndTime" HeaderText="End Time" />
                        <asp:BoundField DataField="TutorialFees" HeaderText="Fees" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblNoTutorial" runat="server" Text="No Tutorials Available" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Total Fees
            </td>
            <td>
                <asp:TextBox ID="txtTotalFees" runat="server" Enabled="false" Text="0"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Food Preferences
            </td>
            <td>
                <asp:DropDownList ID="ddlFoodPreferences" runat="server">
                    <asp:ListItem Text="Vegeterian" Value="Vegeterian"></asp:ListItem>
                    <asp:ListItem Text="Non-Vegeterian" Value="Non-Vegeterian"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Comments
            </td>
            <td>
                <asp:TextBox ID="txtComments" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnSubmit" ValidationGroup="Submit" runat="server" OnClick="btnSubmit_Click"
                    Text="Submit" />
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            </td>
        </tr>
        </table>
    </form>
</body>
</html>
