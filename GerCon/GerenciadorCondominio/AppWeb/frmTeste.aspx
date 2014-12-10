<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTeste.aspx.cs" Inherits="AppWeb.Views.frmTeste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teste</title>
    <script>
        function poptastic(url) {
            newwindow = window.open(url, 'name', 'height=auto,width=auto');
            if (window.focus) { newwindow.focus() }
        }
    </script>    
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Testando a conexão</h1>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" text="NOME"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="283px"></asp:TextBox>
<br />          
<br />
                <asp:Label ID="Label2" runat="server" text="CPF"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="202px"></asp:TextBox>
<br />
<br />
                <asp:Label ID="Label3" runat="server" text="RG"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Width="209px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enviar" />
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
<br />
            </ContentTemplate>
      
        </asp:UpdatePanel>
        
        <br />
        <br />
        
        <br />
        
    </form>
</body>
</html>
