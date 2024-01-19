using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    internal class LikesForPhotos
    {
        internal static void DisplayLikesByMonthBarChart(Album i_Album, System.Windows.Forms.DataVisualization.Charting.Chart io_ChartLikesByMonth)
        {
            io_ChartLikesByMonth.Series.Clear();

            IEnumerable<IGrouping<int, Photo>> groupedPhotos = i_Album.Photos
                .Where(photo => photo.CreatedTime != null) 
                .GroupBy(photo => photo.CreatedTime.Value.Month);

            IEnumerable<object> likesByMonth = groupedPhotos
                .Select(group => new { Month = group.Key, TotalLikes = group.Sum(photo => photo.LikedBy.Count) })
                .OrderBy(item => item.Month)
                .ToList();

            Series series = io_ChartLikesByMonth.Series.Add($"{i_Album.Name} - Likes by Month");

            foreach (object dataPoint in likesByMonth)
            {
                int month = (int)dataPoint.GetType().GetProperty("Month").GetValue(dataPoint);
                int totalLikes = (int)dataPoint.GetType().GetProperty("TotalLikes").GetValue(dataPoint);

                series.Points.AddXY(GetMonthName(month), totalLikes);
            }

            io_ChartLikesByMonth.ChartAreas[0].AxisX.Interval = 1;
            io_ChartLikesByMonth.ChartAreas[0].AxisY.Title = "Number of Likes";
            io_ChartLikesByMonth.ChartAreas[0].AxisX.Title = "Months";
            io_ChartLikesByMonth.ChartAreas[0].RecalculateAxesScale();
        }

        private static string GetMonthName(int monthNumber)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);
        }
    }
}