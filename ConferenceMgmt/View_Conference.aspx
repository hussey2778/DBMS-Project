<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Conference.aspx.cs" Inherits="ConferenceMgmt.View_Conference" MasterPageFile = "Final.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">

    <head>
    <title></title>
</head>
<body>
    <form id="form1" class = "art-postcontent" runat="server">
    <div class = "contents" id = "container">
    <asp:GridView ID="grvConferencesView" AutoGenerateColumns="false" 
        runat="server">
        <Columns>
            <asp:BoundField DataField="ConferenceName" HeaderText="Conference" />
            <asp:BoundField DataField="ConferenceDate" HeaderText="Date" />
            <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
            <asp:BoundField DataField="EndTime" HeaderText="End Time" />
            
                    </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</asp:Content>
