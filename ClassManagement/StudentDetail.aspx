<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetail.aspx.cs" Inherits="ClassManagement.StudentDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:darkgrey;
        }
        .Panel{width: 400px;margin: auto;height: 350px; position:absolute;
               background:url("resources/Images/bg.jpg");
               color:white;
        }
        .header{
            background:url("resources/Images/h.jfif");
border-bottom: 1px solid white;
padding: 5px;
        }
        .PanelBody {
    padding: 10px;
}
        .gvContent {
    width: 100%;
}
        .footer {
    position: absolute;
    bottom: 0px;
    height: 100px;
}
        .btnOption {
                     background:url("resources/Images/h.jfif");
    height: 60px;
    min-width: 80px;
    color:white;
}
        .form-group {
    padding-bottom: 20px;
}
        .lblLabel {
    width: 151px;
    display: block;
    float: left;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Panel" >
            <div class="header">LEERLINGEN SELECTIE</div>
            <div class="PanelBody">
              <div class="form-group">
                  <label><span class="lblLabel">Class:</span><asp:Label ID="lblClass" runat="server"></asp:Label></label>
                  </div>
                  <div class="form-group">
                  <label><span class="lblLabel">Students:</span><asp:Label ID="lblStudents" runat="server"></asp:Label></label>
                  </div>

                 <asp:GridView ID="gvStudent" CssClass="gvContent" runat="server" AutoGenerateColumns="false" >
                <Columns>
            <asp:TemplateField HeaderText="Klass" ItemStyle-Width="5">
                <ItemTemplate>
                  <asp:CheckBox runat="server" Checked='<%# Eval("print") %>' />
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150px" />
                        <asp:BoundField DataField="ReferenceID" HeaderText="ReferenceID" ItemStyle-Width="50px"  ItemStyle-HorizontalAlign="Center"  />
                    
        </Columns>
            </asp:GridView>
                <div class="footer">
             <asp:Button ID="btnSelectALL" runat="server" CssClass="btnOption" OnClick="btnSelectALL_Click" Text="Selecteer Alles" />
 <asp:Button ID="btnUnSelectALL" runat="server" CssClass="btnOption" Text="Deselecteer Alles" OnClick="btnUnSelectALL_Click" />

            <asp:Button ID="btnSave" runat="server" Text="Ok" CssClass="btnOption Right" OnClick="btnSave_Click" />
            <asp:Button ID="btnReturn" runat="server" Text="Terug"  CssClass="btnOption Right" OnClick="btnReturn_Click" />
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
