<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListarUsuario.aspx.cs" Inherits="CapaPresentacion.ListarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <br />
        <h2 style="text-align: center">LISTADO DE USUARIO</h2>
                <!-- Datatable Part -->

        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Lista de Usuarios</h3>
                    </div>
                    <div class="box-body table-responsive">
                        <table id="tbl_usuarios" class="table table-bordered table-hover text-center">
                            <thead>
                                <tr>
                                    <th>Rut</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>Empresa</th>
                                    <th>Departamento</th>
                                    <th>Perfil</th>
                                    <th>Acciones</th>
                                </tr>
                            </thead>
                            <tbody id="tbl_body_table">
                                <!-- DATA POR MEDIO DE AJAX-->
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->
    </section> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
       
</asp:Content>
