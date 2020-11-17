<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="arquitectura_de_capas_formulario_citas.aspx.cs" Inherits="arquitecturaDeCapas.arquitectura_de_capas_formulario_citas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>CODIGO CITA:</td>
                <td>
                    <asp:TextBox ID="txt_cod_cita" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_consultar_cita" runat="server" OnClick="btn_consultar_cita_Click" Text="Consultar cita" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>FECHA:</td>
                <td>
                    <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>HORA:</td>
                <td>
                    <asp:TextBox ID="txt_hora" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID PACIENTE:</td>
                <td>
                    <asp:TextBox ID="txt_id_paciente" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_consultar_paciente" runat="server" Text="Consultar paciente" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID MEDICO:</td>
                <td>
                    <asp:TextBox ID="txt_id_medico" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_consultar_medico" runat="server" Text="Consultar medico" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>VALOR:</td>
                <td>
                    <asp:TextBox ID="txt_valor" runat="server"></asp:TextBox>
                    <asp:Label ID="lbl_resultado_bool" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>DIÁGNOSTICO</td>
                <td>
                    <asp:TextBox ID="txt_diagnostico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>NOMBRE ACOMPAÑANTE</td>
                <td>
                    <asp:TextBox ID="txt_nombre_acompanante" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_guardar" runat="server" OnClick="Button1_Click" Text="Guardar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
