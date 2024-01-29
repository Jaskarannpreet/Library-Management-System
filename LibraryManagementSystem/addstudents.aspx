<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="addstudents.aspx.cs" Inherits="LibraryManagementSystem.addstudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="JavaScript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <section>
        <div class="container-fluid bg-primary p-2">
            <div class="row">
                <div class="col-lg-12">
                    <input type="button" id="Back" value="Back" class="btn-success" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    Name
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="text" placeholder="Enter Book Genre" id="Name" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    Contact
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="text" placeholder="Enter Book Auther" id="Contact" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    DateOfBirth
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="date" placeholder="Enter Book Publisher" id="DateOfBirth" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    Gender
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="text" placeholder="Enter Published Date" id="Gender" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    Father Name
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="text" placeholder="Enter Book Edition" id="FatherName" />
                </div>
                <div class="col-md-1 col-lg-1 col-sm-2">
                    Photo
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="image" placeholder="Enter Book Language" id="Photo" />
                </div><div class="col-md-1 col-lg-1 col-sm-2">
                    Email
                </div>
                <div class="col-md-1 col-lg-2 col col-sm-3">
                    <input type="text" placeholder="Enter Book Volume" id="Email" />
                </div>
               
               
                    <div class="col-md-1 col-lg-1  col-sm-2 ml-10">
                        <input type="button" value="Add" id="AddStudent" class=" ml-10 width btn-success"/>
                    </div> 
            </div>
        </div>
    </section>
     <section>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 mt-2">
                    <form runat="server">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" AllowSorting="true" OnSorting="GridView1_Sorting">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" CssClass="p-1" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                    </form>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
