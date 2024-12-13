using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();


        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.LocationCapasity).ToString();
            lblGuideCount.Text= db.Guide.Count().ToString();
            lblAvgCapacity.Text=db.Location.Average(x=> x.LocationCapasity).Value.ToString("F2");
            lblAvgPrice.Text=db.Location.Average(x => x.LocationPrice).Value.ToString("F2")+" "+ "₺";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapasity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.LocationCountry == "Türkiye").Average(y => y.LocationCapasity).ToString();

            var romeGuideId = db.Location.Where(x => x.LocationCity == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lbRomeGuidename.Text=db.Guide.Where(x=>x.GuideId== romeGuideId).Select(y=>y.GuideName + " " +
            y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.LocationCapasity);
            lblMaxCapacityTour.Text=db.Location.Where(x=>x.LocationCapasity==maxCapacity).Select(y=>y.LocationCity).First().ToString();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceTour.Text = db.Location.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).First().ToString();

            var guideIdByNameAliYildiz = db.Guide.Where(x => x.GuideName == "Ali" && x.GuideSurname == "Yıldız").Select
                (y => y.GuideId).FirstOrDefault();
            lblAliYildizTourCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAliYildiz).Count().ToString();

        }

        private void lblLastCountryName_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
