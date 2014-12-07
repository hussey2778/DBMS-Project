<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adm_Activity.aspx.cs" Inherits="ConferenceMgmt.Adm_Activity" MasterPageFile = "Final.Master" %>



<asp:Content ContentPlaceHolderID="AA1" runat ="server">
    <body>
    <form id="form1" runat="server" class = "art-postcontent">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Activity" EnableViewState="false"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtActivity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" ForeColor="Red" ControlToValidate="txtActivity"
                        ID="RequiredFieldValidator9" ValidationGroup="saveActivity" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnSave" ValidationGroup="saveActivity" runat="server" OnClick="btnSave_Click"
                        Text="Save" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td colspan="2">                  
                    <asp:GridView ID="grvActivities" AutoGenerateColumns="false" runat="server" OnRowCommand="grvActivities_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="ActivityName" HeaderText="Activity" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("ActivityID") %>' CommandName="EditActivity"
                                        runat="server">Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("ActivityID") %>' CommandName="DeleteActivity"
                                        runat="server">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="hdnActivityId" Value="0" runat="server" />
    </div>
    </form>
</body>
</asp:Content>

