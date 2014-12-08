<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adm_Tutorial.aspx.cs" Inherits="ConferenceMgmt.Adm_Tutorial"
    MasterPageFile="Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat="server">
    <form id="form1" runat="server" class="art-postcontent">
    <table>
        <tr>
            <td>
                Tutorial Name
            </td>
            <td width="78%">
                <asp:TextBox ID="txtTutorialName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="Submit" runat="server" ControlToValidate="txtTutorialName"
                    ErrorMessage="Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Tutorial Date (mm/dd/yyyy)
            </td>
            <td width="78%">
                <asp:TextBox ID="txtTutorialDate" runat="server"></asp:TextBox>
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
                Tutorial Fees
            </td>
            <td>
                <asp:TextBox ID="txtTutorialFee" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="Submit" ID="RequiredFieldValidator1"
                    runat="server" ControlToValidate="txtTutorialFee" ErrorMessage="Required"></asp:RequiredFieldValidator>
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
        <asp:HiddenField ID="hdnTutorialID" Value="0" runat="server" />
    </p>
    <asp:GridView ID="grvTutorials" AutoGenerateColumns="false" OnRowCommand="grvTutorials_RowCommand"
        runat="server">
        <Columns>
            <asp:BoundField DataField="TutorialName" HeaderText="Tutorial" />
            <asp:BoundField DataField="TutorialDate" HeaderText="Date" />
            <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
            <asp:BoundField DataField="EndTime" HeaderText="End Time" />
            <asp:BoundField DataField="TutorialFees" HeaderText="Fees" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("TutorialID") %>' CommandName="EditTutorial"
                        runat="server">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("TutorialID") %>' CommandName="DeleteTutorial"
                        runat="server">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
    </form>
   
    <script language="javascript" type="text/javascript">
        $(document).ready(function () {           
            $('#AA1_txtStartTime').timepicker({});
            $('#AA1_txtEndTime').timepicker({});
            $('#AA1_txtTutorialDate').datepicker({ 'autoclose': true });
        });
    </script>
</asp:Content>
