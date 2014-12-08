<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Tutorial.aspx.cs"
    Inherits="ConferenceMgmt.View_Tutorial" MasterPageFile="Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat="server">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" class="art-postcontent" runat="server">
        <div class="contents" id="container">
            <asp:GridView ID="grvTutorialsView" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField DataField="TutorialName" HeaderText="Tutorial" />
                    <asp:BoundField DataField="TutorialDate" HeaderText="Date" />
                    <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
                    <asp:BoundField DataField="EndTime" HeaderText="End Time" />
                </Columns>
            </asp:GridView>
        </div>
        </form>
    </body>
</asp:Content>
