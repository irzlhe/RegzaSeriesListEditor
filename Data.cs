using System;
using System.Collections.Generic;
using System.Text;

namespace RegzaSeriesListEditor
{
    class FileData
    {
        public int index;
        public string filename;
        public int seriesId;
        public MetaData metaData;
        public int? newSeriesId;

        public bool IsValid()
        {
            return metaData != null && seriesId == metaData.seriesId;
        }
        public int GetSeriesId()
        {
            return newSeriesId ?? seriesId;
        }
        public void SetSeriesId(int id)
        {
            newSeriesId = id;
        }
        public bool IsDirty()
        {
            return newSeriesId != null && newSeriesId.Value != seriesId;
        }
    }

    class MetaData
    {
        public string title;
        public DateTime date;
        public int seriesId;
    }

    class SeriesData
    {
        public int index;
        public int id;
        public string name;
        public int count;

        public string Name
        {
            get { return name; }
        }
    }
}
