<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="school.aspx.cs" Inherits="ClassManagement.school" %>

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
        .white{
            color:white !important;
        }
        .btnOption {
            margin-top: 25px;
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
            <div class="header">KLASSEN SELECTIE</div>
            <div class="PanelBody">
              <div class="form-group">
                  <label><span class="lblLabel">Zoek op naam:</span><asp:Textbox ID="txtZoek" runat="server"></asp:Textbox></label>
                  </div>
                  <div class="form-group">
                  <label><span class="lblLabel">Toon: </span><asp:DropDownList ID="ddlToon" runat="server" Width="100">
                      <asp:ListItem Text="L" Value="L" Selected="True" />
                               </asp:DropDownList></label>
                  </div>

            <asp:GridView ID="gvClass" runat="server" CssClass="gvContent" AutoGenerateColumns="false" >
             <Columns>
                   <asp:TemplateField HeaderText=" " ItemStyle-Width="5">
                <ItemTemplate>
                  <asp:CheckBox runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ItemStyle-Width="100" HeaderText="Klass">

                <ItemTemplate>
                    <asp:LinkButton runat="server" CssClass="white"  PostBackUrl='<%# string.Concat("StudentDetail.aspx?className=", Eval("Klass")) %>' Text='<%# Eval("Klass") %>' ></asp:LinkButton>
                  
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:BoundField DataField="Level" HeaderText="Level" ItemStyle-Width="50px"  ItemStyle-HorizontalAlign="Center" />
                   <asp:BoundField DataField="School" HeaderText="School" ItemStyle-Width="10px"  ItemStyle-HorizontalAlign="Center"  />
                   <asp:BoundField DataField="Leerlingen" HeaderText="Leerlingen" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
        </Columns>
            </asp:GridView>
                               <div class="footer">
             <asp:Button ID="btnSelectALL" runat="server" Enabled="false" CssClass="btnOption"  Text="Zoek" />
 <asp:Button ID="btnUnSelectALL" runat="server" Enabled="false" CssClass="btnOption"  Text="Wis" />

            <asp:Button ID="btnSave" runat="server"  Enabled="false" Text="Select" CssClass="btnOption Right"  />
            <asp:Button ID="btnReturn" runat="server" Enabled="false" Text="Annuler"  CssClass="btnOption Right" />
                    </div>
                </div>
        
        </div>
    </form>
</body>
</html>
