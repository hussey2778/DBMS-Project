<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adm_Paper.aspx.cs" Inherits="ConferenceMgmt.Adm_Paper" MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">
    <head>
    <title></title>
</head>
<body>
    <form id="form1" class = "art-postcontent" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="grvPaper" AutoGenerateColumns="false" OnRowCommand="grvPaper_RowCommand"
        runat="server"  
 DataKeyNames="Paperid" >
        <Columns>
            
            <asp:BoundField DataField="PaperID" HeaderText="PaperID" />
            <asp:BoundField DataField="PaperName" HeaderText="Paper Name" />
            <asp:BoundField DataField="PaperFees" HeaderText="Paper Fees" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="isAccepted" HeaderText="Accepted" />
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="Edit" CommandArgument='<%# Bind("PaperID") %>' CommandName="DownloadPaper"
                        runat="server">Download</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="cbSelectPaper" runat="server" />
                                </ItemTemplate>
                        </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
    <br />
    <asp:TextBox ID="txtPaperID" runat="server" Visible="False"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Accept" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Reject" onclick="Button2_Click" />
    </form>
</body>
</asp:Content>
