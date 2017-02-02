using System;

namespace Negocio.CodigosDeReferencia.ConObjetos
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElRequerimientoComoTexto(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo)
        {
            string laFechaFormateada = ObtengaLaFechaFormateada(laFecha);
            string elClienteAjustado = AjusteElCliente(elCliente);
            string elSistemaAjustado = AjusteElSistema(elSistema);
            string elConsecutivoAjustado = AjusteElConsecutivo(elConsecutivo);

            return FormateeElRequerimiento(laFechaFormateada, elClienteAjustado, elSistemaAjustado, elConsecutivoAjustado);
        }

        private static string ObtengaLaFechaFormateada(DateTime laFecha)
        {
            string elAñoAjustado = ObtengaElAñoAjustado(laFecha);
            string elMesAjustado = OtengaElMesAjustado(laFecha);
            string elDiaAjustado = ObtengaElDiaAjustado(laFecha);

            return FormateeLaFecha(elAñoAjustado, elMesAjustado, elDiaAjustado);
        }

        private static string ObtengaElAñoAjustado(DateTime laFecha)
        {
            int elAño = ExtraigaElAño(laFecha);

            return AjusteElAño(elAño);
        }

        private static int ExtraigaElAño(DateTime laFecha)
        {
            return laFecha.Year;
        }

        private static string AjusteElAño(int elAño)
        {
            return elAño.ToString("D4");
        }

        private static string OtengaElMesAjustado(DateTime laFecha)
        {
            int elMes = ExtraigaElMes(laFecha);

            return AjusteElMes(elMes);
        }

        private static int ExtraigaElMes(DateTime laFecha)
        {
            return laFecha.Month;
        }

        private static string AjusteElMes(int elMes)
        {
            return elMes.ToString("D2");
        }

        private static string ObtengaElDiaAjustado(DateTime laFecha)
        {
            int elDia = ObtengaElDia(laFecha);

            return AjusteElDia(elDia);
        }

        private static int ObtengaElDia(DateTime laFecha)
        {
            return laFecha.Day;
        }

        private static string AjusteElDia(int elDia)
        {
            return elDia.ToString("D2");
        }

        private static string FormateeLaFecha(string elAñoAjustado, string elMesAjustado, string elDiaAjustado)
        {
            return elAñoAjustado + elMesAjustado + elDiaAjustado;
        }

        private static string AjusteElCliente(short elCliente)
        {
            return elCliente.ToString("D3");
        }

        private static string AjusteElSistema(short elSistema)
        {
            return elSistema.ToString("D2");
        }

        private static string AjusteElConsecutivo(string elConsecutivo)
        {
            return elConsecutivo.PadLeft(12, '0');
        }

        private static string FormateeElRequerimiento(string laFechaFormateada, string elClienteAjustado, string elSistemaAjustado, string elConsecutivoAjustado)
        {
            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}