using CSIPJR.Domain;
using CSIPJR.Domain.Class;
using CSIPJR.Domain.Enums;
using CSIPJR.Domain.Interface;

//EN LA PANTALLA DE PROFESORES
IExportData<Profesor> exportData = new ExportData<Profesor>();

InstructorSearch instructorSearch = new InstructorSearch();

var datos = instructorSearch.SearchByArea("Matematica");

exportData.ExportTo(ExportType.Csv, datos);


// EN LA PANTALLA DE ESTUDIANTES

IExportData<Estudiante> exportarEstudianteData = new ExportData<Estudiante>();

StudentSearch studentSearch = new StudentSearch();

var datosEstudiante = studentSearch.SearchByCourse("SQL");

exportarEstudianteData.ExportTo(ExportType.Pdf, datosEstudiante);
