<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="Summer_School_Registration_System.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--CONTENT İÇERİSİNE KODUMUZU YAZIYORUZ.-->
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Şifre</th>
            <th>Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <!--Verilerimizi listelemek için kullanacağımız araç.-->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <!--Öğelerin tutulacağı yapı.-->
                    <tr>
                        <td><%# Eval("id") %></td> <!--Eval verileri alınıp tutulduğu metottur.-->
                        <td><%# Eval("ad") %></td>
                        <td><%# Eval("soyad") %></td>
                        <td><%# Eval("numara") %></td>
                        <td><%# Eval("fotograf") %></td>
                        <td><%# Eval("sifre") %></td>
                        <td><%# Eval("bakiye") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgrenciSil.aspx?id=" + Eval("id") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgrenciGuncelle.aspx?id=" + Eval("id") %>' CssClass="btn btn-success" runat ="server">Güncelle</asp:HyperLink>
                            <!--Hyper link ile aslında text bir link koymuş oluruz.-->
                            <!--Cssclass btn ile bunun bir buton olduğunu belirliyoruz.-->
                            <!--Navigate bar bize yönlendirme sunar.-->
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
