<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaperSubmission.aspx.cs"
    Inherits="ConferenceMgmt.PaperSubmission" MasterPageFile="Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat="server">
    <head>
        <title></title>
    </head>
    <body>
        <form id="form1" class="art-postcontent" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Paper" EnableViewState="false"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPaper" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator Display="Dynamic" ForeColor="Red" ControlToValidate="txtPaper"
                            ID="RequiredFieldValidator9" ValidationGroup="savePaper" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Paper" EnableViewState="false"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlConference" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator Display="Dynamic" ForeColor="Red" ControlToValidate="ddlConference"
                            ID="RequiredFieldValidator1" ValidationGroup="savePaper" runat="server" InitialValue="0"
                            ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Paper" EnableViewState="false"></asp:Label>
                    </td>
                    <td>
                        <asp:FileUpload ID="fuPaper" runat="server" />
                        <asp:RequiredFieldValidator Display="Dynamic" ForeColor="Red" ControlToValidate="fuPaper"
                            ID="RequiredFieldValidator2" ValidationGroup="savePaper" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Fees" EnableViewState="false"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblFees" runat="server" Text="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnSave" ValidationGroup="savePaper" runat="server" OnClick="btnSave_Click"
                            Text="Save" />
                        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                    </td>
                </tr>
                <%-- <tr>
                <td colspan="2">                  
                    <asp:GridView ID="grvActivities" AutoGenerateColumns="false" runat="server" OnRowCommand="grvActivities_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="PaperName" HeaderText="Paper" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("PaperID") %>' CommandName="EditPaper"
                                        runat="server">Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Bind("PaperID") %>' CommandName="DeletePaper"
                                        runat="server">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <br />
                    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>--%>
            </table>
            <asp:HiddenField ID="hdnPaperId" Value="0" runat="server" />
        </div>
        </form>
    </body>
</asp:Content>
