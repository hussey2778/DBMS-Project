<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs"
    Inherits="ConferenceMgmt.Payment" MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">

    <body>
    <form name="form1" class = "art-postcontent" runat="server">
    <table width="95%" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top: 8px;
        text-align: left;">
        <tr id="trTotal">
            <td>
                Total
            </td>
            <td>
                <asp:TextBox ID="txtFees" runat="server" Enabled="False" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Card Number
            </td>
            <td>
                <asp:TextBox ID="txtCardNo" runat="server" ></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                Card Holder Name
            </td>
            <td>
                <asp:TextBox ID="txtCardHolderName" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Expire Date
            </td>
            <td >
                mm :
                <asp:TextBox Width="50px" ID="txtExpDateMM" runat="server" ></asp:TextBox>
                yyyy :
                <asp:TextBox Width="50px" ID="txtExpDateYYYY" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Security Code
            </td>
            <td>
                <asp:TextBox Width="50px" ID="txtSecurirtyCode" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td >
                <asp:CheckBox ID="cbSaveCard" runat="server"></asp:CheckBox>
                Save this card for future registrations
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button runat="server" ID="btnSubmit" Text="Submit" 
                    onclick="btnSubmit_Click" />
                <asp:Button runat="server" ID="btnCancel" Text="Cancel" />
            </td>
        </tr>
    </table>
    </form>
</body>
</asp:Content>
