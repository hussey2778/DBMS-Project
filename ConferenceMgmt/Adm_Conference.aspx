<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adm_Conference.aspx.cs" Inherits="ConferenceMgmt.Adm_Conference" MasterPageFile = "Final.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {
            $('#txtStartTime').timepicker({});
            $('#txtEndTime').timepicker({});
            $('#txtConferenceDate').datepicker({ 'autoclose': true });
        });
    </script>
    <form id="form1" class = "art-postcontent" runat="server">
    <table>
        <tr>
            <td>
                Conference Name
            </td>
            <td width="78%">
                <asp:TextBox ID="txtConferenceName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Submit"
                    runat="server" ControlToValidate="txtConferenceName" ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Conference Date (mm/dd/yyyy)
            </td>
            <td width="78%">
                <asp:TextBox ID="txtConferenceDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Start Time
            </td>
            <td>
                <asp:TextBox ID="txtStartTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                End Time
            </td>
            <td>
                <asp:TextBox ID="txtEndTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Conference Fees
            </td>
            <td>
                <asp:TextBox ID="txtConferenceFee" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="Submit" ID="RequiredFieldValidator2"
                    runat="server" ControlToValidate="txtConferenceFee" ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Tutorials
            </td>
            <td>
                <asp:ListBox ID="lstTutorials" Width="225px" runat="server" SelectionMode="Multiple"></asp:ListBox>
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
        <asp:HiddenField ID="hdnConferenceID" Value="0" runat="server" 
         />
    </p>
    <asp:GridView ID="grvConferences" AutoGenerateColumns="false" OnRowCommand="grvConferences_RowCommand"
        runat="server">
        <Columns>
            <asp:BoundField DataField="ConferenceName" HeaderText="Conference" />
            <asp:BoundField DataField="ConferenceDate" HeaderText="Date" />
            <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
            <asp:BoundField DataField="EndTime" HeaderText="End Time" />
            <asp:BoundField DataField="ConferenceFees" HeaderText="Fees" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("ConferenceID") %>' CommandName="EditConference"
                        runat="server">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("ConferenceID") %>' CommandName="DeleteConference"
                        runat="server">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
    </form>
</asp:Content>
