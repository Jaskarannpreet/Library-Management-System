<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="allstudents.aspx.cs" Inherits="LibraryManagementSystem.allstudents" %>
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
        <div class="container-fluid">
            <div class="row bg-primary  p-2">
                <div class="col-lg-12">
                    <input type="button" id="Back" value="Back" class="btn-success" />
                </div>
                <div class="col-lg-1 col-md-1 col-sm-1 mtb-2">
                    <b>Name:</b>
                </div>
                <div class="col-lg-2 col-md-2 mtb-2 ">
                    <span id="UserName" runat="server"></span>
                </div>
                <div class="col-lg-1 col-md-1 col-sm-1  mtb-2 ">
                    <b>Contact:</b>
                </div>
                <div class="col-lg-2 col-md-2 mtb-2 ">
                    <span id="Contact" runat="server"></span>
                </div>
               
                <div class="col-lg-1 col-md-1 col-sm-1  mtb-2 ">
                    <b>Date Of Birth:</b>
                </div>
                <div class="col-lg-2 col-md-2  mtb-2 ">
                    <span id="DateOfBirth" runat="server"></span>
                </div>
                <div class="col-lg-1 col-md-1 mtb-2 col-sm-1 col-sm-1 ">
                    <b>Gender</b>
                </div>
                <div class="col-lg-2 mtb-2  col-md-2 ">
                    <span runat="server" id="Gender"></span>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 mt-2">
                    <form runat="server">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%"  AllowSorting="true" >
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
