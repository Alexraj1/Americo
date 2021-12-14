<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClassManagement.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('#example').DataTable({
                "processing": true,
                "serverSide": true,
                "ajax": "/resources/WebServices/WSClassDetails.asmx/GetAllClasses"
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddlClass" runat="server" >
    </asp:DropDownList>
    <table id="example" class="display" style="width:100%">
        <thead>
            <tr>
                <th>V</th>
            </tr>
        </thead>
      
            </table>
</asp:Content>
