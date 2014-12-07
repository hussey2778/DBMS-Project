<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index_view.aspx.cs" Inherits="ConferenceMgmt.index_view" MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">

                    <form name="form1" class = "art-postcontent" runat="server">
                    <table width="70%" border="0" cellspacing="0" cellpadding="0" align="center" style="margin-top: 8px;
                        text-align: left;">
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Name
                            </td>
                            <td width="78%">
                               <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                        </tr>                        
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Institution
                            </td>
                            <td>
                                <asp:Label ID="lblInstitution" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td width="30%" height="38" style="font-size: 12px;">
                                Email
                            </td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    </form>
                    </asp:Content>