<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TutorialRegistration.aspx.cs"
    Inherits="ConferenceMgmt.TutorialRegistration" MasterPageFile="Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat="server">
    <head>
        <title></title>
        <script language="javascript" type="text/javascript">

            $(document).ready(function () {

                $('input:checkbox[id*=cbSelectTutorial]').click(function () {
                    var $tr = $(this).closest('tr');
                    var tutorialFees = $tr.find("input:hidden[name$=hdnTutorialFees]").val();
                    var total = parseFloat($("#AA1_txtTotalFees").val());
                    if ($(this).is(':checked')) {

                        total = total + parseFloat(tutorialFees);
                    }
                    else {
                        total = total - parseFloat(tutorialFees);
                    }
                    $("#AA1_txtTotalFees").val(total);
                });
            });
        </script>
    </head>
    <body>
        <form id="form1" class="art-postcontent" runat="server">
        <table>
            <tr>
                <td>
                    Tutorials
                </td>
                <td>
                    <asp:Label ID="lblError" ForeColor="Red" runat="server"></asp:Label>
                    <asp:GridView ID="grvTutorials" AutoGenerateColumns="false" runat="server" DataKeyNames="TutorialID">
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
                    <asp:TextBox ID="txtTotalFees" runat="server" Text="0"></asp:TextBox>
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
        </form>
    </body>
</asp:Content>
