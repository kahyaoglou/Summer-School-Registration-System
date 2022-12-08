<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="Summer_School_Registration_System.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label runat="server" Text="Oğrenci ID: "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div>
            <!--Form olmadan dropdown çalışırsa sayfa hata verecektir.-->
            <asp:Label runat="server" Text="Ders Seçin: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            <!--Form control ile drop down sayfayı enlemesine kaplayacaktır.-->
        </div>
        <br />

        <br /> 
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur." CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
