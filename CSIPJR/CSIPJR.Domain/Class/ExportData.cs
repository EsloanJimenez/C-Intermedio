using CSIPJR.Domain.Enums;
using CSIPJR.Domain.Interface;

namespace CSIPJR.Domain.Class
{
    public class ExportData<TData> : IExportData<TData>
    {
        private List<TData> _data;
        public ExportData()
        {
            _data = new List<TData>();
        }

        public void ExportTo(ExportType exportType, List<TData> data)
        {
            switch(exportType)
            {
                case ExportType.Pdf:
                    break;
                case ExportType.Csv:
                    break;
                case ExportType.Xml:
                    break;
                default:
                    break;
            }
        }

        public void ExportTo(ExportType pdf, List<Student> datosEstudiante)
        {
            throw new NotImplementedException();
        }
        /*
public void ExportToCsv(List<TData> data)
{
   throw new NotImplementedException();
}

public void ExportToPdf(List<TData> data)
{
   throw new NotImplementedException();
}

public void ExportToXml(List<TData> data)
{
   throw new NotImplementedException();
}
*/
    }
}
