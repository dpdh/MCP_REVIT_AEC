using Autodesk.Revit.DB;

namespace RevitAddinMvc
{
    /// <summary>
    /// Model class that holds the data and business logic for the Addin
    /// </summary>
    public class RevitAddinModel
    {
        private Document _doc;

        public RevitAddinModel(Document doc)
        {
            _doc = doc;
        }

        /// <summary>
        /// Get all walls in the current document
        /// </summary>
        public Wall[] GetAllWalls()
        {
            FilteredElementCollector collector = new FilteredElementCollector(_doc);
            collector.OfClass(typeof(Wall));
            return collector.ToElements().Cast<Wall>().ToArray();
        }

        /// <summary>
        /// Get the total number of levels in the document
        /// </summary>
        public int GetLevelCount()
        {
            FilteredElementCollector collector = new FilteredElementCollector(_doc);
            collector.OfClass(typeof(Level));
            return collector.ToElements().Count;
        }

        /// <summary>
        /// Create a simple note element at a given location
        /// </summary>
        public Note CreateNote(XYZ location, string text, View view)
        {
            Note note = Note.Create(_doc, view.Id, location, text);
            return note;
        }

        /// <summary>
        /// Get the active view
        /// </summary>
        public View GetActiveView()
        {
            return _doc.ActiveView;
        }
    }
}