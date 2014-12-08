<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adm_Statistics.aspx.cs" Inherits="ConferenceMgmt.Adm_Statistics" MasterPageFile = "Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">
    <head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class = "art-postcontent">
    User Conference Details:<br /><br />


    <div class = "contents" id = "container">
    <asp:GridView ID="grvConferencesViewStatistics" AutoGenerateColumns="false" 
        runat="server">
        
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" />
            <asp:BoundField DataField="ConferenceID" HeaderText="ConferenceID" />
            <asp:BoundField DataField="ConferenceName" HeaderText="ConferenceName" />
            <asp:BoundField DataField="ConferenceDate" HeaderText="ConferenceDate" />
            <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
            <asp:BoundField DataField="EndTime" HeaderText="End Time" />
            <asp:BoundField DataField="PaperID" HeaderText="PaperID" />
            <asp:BoundField DataField="PaperName" HeaderText="PaperName" />
            <asp:BoundField DataField="Filename" HeaderText="Filename" />
            <asp:BoundField DataField="Paperfees" HeaderText="Paperfees" />
            <asp:BoundField DataField="IsAccepted" HeaderText="Accepted" />
            <asp:BoundField DataField="PaymentID" HeaderText="PaymentID" />
            <asp:BoundField DataField="RegistrationType" HeaderText="RegistrationType" />
            <asp:BoundField DataField="RegistrationTypeID" HeaderText="RegistrationTypeID" />
            <asp:BoundField DataField="CreditCardNumber" HeaderText="CreditCardNumber" />
            <asp:BoundField DataField="FoodPreferenece" HeaderText="FoodPreferenece" />
            <asp:BoundField DataField="Comments" HeaderText="Comments" />
            <asp:BoundField DataField="ActivityName" HeaderText="ActivityName" />
                    
           
            
            
                    </Columns>
    </asp:GridView>
    </div>
    <br />
    <asp:Button ID="btnExportcsv1" runat="server" Text="Export to CSV" 
        onclick="btnExportcsv1_Click" />
    <br />
    <br />
    User Tutorial Details:<br />
    <br />
    <div class = "contents" id = "container">
    <asp:GridView ID="grvTutorialsViewStatistics" AutoGenerateColumns="false" 
        runat="server">
        
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" />
            <asp:BoundField DataField="TutorialID" HeaderText="TutorialID" />
            <asp:BoundField DataField="TutorialName" HeaderText="TutorialName" />
            <asp:BoundField DataField="TutorialDate" HeaderText="TutorialDate" />
            <asp:BoundField DataField="StartTime" HeaderText="Start Time" />
            <asp:BoundField DataField="EndTime" HeaderText="End Time" />
            <asp:BoundField DataField="TutorialFees" HeaderText="TutorialFees" />
            <asp:BoundField DataField="PaymentID" HeaderText="PaymentID" />
            <asp:BoundField DataField="RegistrationType" HeaderText="RegistrationType" />
            <asp:BoundField DataField="RegistrationTypeID" HeaderText="RegistrationTypeID" />
            <asp:BoundField DataField="CreditCardNumber" HeaderText="CreditCardNumber" />
                     
            
                    </Columns>
    </asp:GridView>
    </div>
    <br />
    <asp:Button ID="ExportCSV2" runat="server" onclick="ExportCSV2_Click" 
        Text="Export to CSV" />
    <br />
    <br />
    Paper Submission Report:<br />
    <br />
    <div class = "contents" id = "container">
    <asp:GridView ID="grvPaperStatistics" AutoGenerateColumns="false" 
        runat="server">
        
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" />
            <asp:BoundField DataField="PaperID" HeaderText="PaperID" />
            <asp:BoundField DataField="FileName" HeaderText="FileName" />
            <asp:BoundField DataField="PaperName" HeaderText="PaperName" />
            <asp:BoundField DataField="PaperFees" HeaderText="PaperFees" />
            <asp:BoundField DataField="IsAccepted" HeaderText="IsAccepted" />
            
                    </Columns>
    </asp:GridView>
     </div>
    <br />
    <asp:Button ID="btnExportCSV3" runat="server" onclick="btnExportCSV3_Click" 
        Text="Export to CSV" />
    <br />
    </form>
</body>
</asp:Content>

