using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public static class InfoPDF
    {
         public static String obtenerTexto(String stRutaArchivo)
        {
            iTextSharp.text.pdf.PdfReader pdfleer = new iTextSharp.text.pdf.PdfReader(stRutaArchivo);
            String stElTexto = String.Empty;
            int iPaginas = pdfleer.NumberOfPages;
            if (iPaginas > 0)
            {
                for (int i = 1; i <= iPaginas; i++)
                {
                    stElTexto += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(pdfleer, i) + Environment.NewLine;
                }
            }

            return stElTexto;
        }

    }
}
