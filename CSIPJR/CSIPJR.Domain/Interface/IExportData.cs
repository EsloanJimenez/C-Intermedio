using CSIPJR.Domain.Enums;

namespace CSIPJR.Domain.Interface
{
    public interface IExportData<TData>
    {
        /*
        void ExportToCsv(List<TData> data);
        void ExportToXml(List<TData> data);
        void ExportToPdf(List<TData> data);
        */
        void ExportTo(ExportType exportType, List<TData> data);
        void ExportTo(ExportType pdf, List<Student> datosEstudiante);
        //void ExportToPdf(List<Student> datosEstudiante);
    }
}
