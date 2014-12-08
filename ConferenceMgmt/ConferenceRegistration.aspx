<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConferenceRegistration.aspx.cs"
    Inherits="ConferenceMgmt.ConferenceRegistration"  MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">
    <head>
    <title></title>
   
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
    <form id="form1" class = "art-postcontent" runat="server">
    <table>
        <tr>
            <td>
                Conference Name
            </td>
            <td width="78%">
                <asp:DropDownList ID="ddlCoferenceName" runat="server" AutoPostBack="true"
                    OnSelectedIndexChanged="ddlCoferenceName_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Conference Date (mm/dd/yyyy)
            </td>
            <td width="78%">
                <asp:Label ID="lblConferenceDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Start Time
            </td>
            <td>
                <asp:Label ID="lblStartTime" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                End Time
            </td>
            <td>
                <asp:Label ID="lblEndTime" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Activities
            </td>
            <td>
                <asp:ListBox ID="lstActivities" Width="225px" runat="server" SelectionMode="Multiple"></asp:ListBox>
            </td>
        </tr>        
        <tr>
            <td>
                Conference Fees
            </td>
            <td>
                <asp:Label ID="lblConferenceFees" runat="server"></asp:Label>
            </td>
        </tr>
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
    <p>
        <asp:HiddenField ID="hdnConferenceID" Value="0" runat="server" />
    </p>
    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
    </form>
</body>
</asp:Content>
