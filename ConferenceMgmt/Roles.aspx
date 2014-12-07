<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="ConferenceMgmt.Roles" MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">

    <form id="form1" class = "art-postcontent" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Role" EnableViewState="false"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" ForeColor="Red" ControlToValidate="txtRole"
                        ID="RequiredFieldValidator9" ValidationGroup="saveRole" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnSave" ValidationGroup="saveRole" runat="server" OnClick="btnSave_Click"
                        Text="Save" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <%--<asp:GridView ID="gvRoles" runat="server" OnRowCommand="gvRoles_RowCommand" AutoGenerateColumns="false"
                        OnRowEditing="gvRoles_RowEditing">
                        <Columns>
                            <asp:BoundField DataField="RoleName" HeaderText="Role" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("RoleID") %>' CommandName="Edit"
                                        runat="server">Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("RoleID") %>' CommandName="Remove"
                                        runat="server">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>--%>
                    <asp:GridView ID="grvRoles" AutoGenerateColumns="false" runat="server" OnRowCommand="grvRoles_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="RoleName" HeaderText="Role" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("RoleID") %>' CommandName="EditRole"
                                        runat="server">Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("RoleID") %>' CommandName="DeleteRole"
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
        <asp:HiddenField ID="hdnRoleId" Value="0" runat="server" />
    </div>
    </form>
    </asp:Content>

