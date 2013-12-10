using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace Malzeme
{
    public partial class MalzemeGenel : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindMalzemeTuru();
                BindUretimYeri();
                BindTemelOlcuBirimi();
                BindMalGrubu();
                BindMIPKrk();
                BindMIPSorumlusu();
                BindTedarikTuru();
                BindOnayDurum();

                ddlOnayDurum.Enabled = false;

                txtKayitTarihi.Text = DateTime.Now.ToShortDateString();
                if (Request.QueryString["MalzemeKodu"] != null)
                {
                    int malzemeKodu = Convert.ToInt32(Request.QueryString["MalzemeKodu"]);
                    BindMalzemeInfo(malzemeKodu);
                }

                int statu = Convert.ToInt32(Session["UserStatu"]);

                if (statu == 1)
                {
                    btnKaydet.Visible = true;
                    btnOnay.Visible = true; ;
                    btnFinans.Visible = false;
                    btnSatinAlma.Visible = false;
                }

                if (statu == 2)
                {
                    btnKaydet.Visible = false;
                    btnOnay.Visible = true;
                    btnFinans.Visible = false;
                    btnSatinAlma.Visible = true;
                }
                else if (statu == 3)
                {
                    btnKaydet.Visible = false;
                    btnOnay.Visible = true;
                    btnFinans.Visible = true;
                    btnSatinAlma.Visible = false;
                }
                else if (statu == 4)
                {
                    btnKaydet.Visible = false;
                    btnOnay.Visible = true;
                    btnFinans.Visible = false;
                    btnSatinAlma.Visible = false;
                    btnGonder.Visible = false;
                }


            }

            //Request.QueryString ile browserda malzeme kodunun gorulmesı sagllandı


        }

        public void BindMalzemeInfo(int malzemeKodu)
        {
            tMlzGenel genel = new tMlzGenel();
            var data = dc.tMlzGenels.Where(x => x.MalzemeKodu == malzemeKodu);
            //bu malzeme kodunu ılk buldugunu getır 
            if (data.Count() > 0)
            {
                txtMalzemeKodu.Text = data.First().MalzemeKodu.ToString();
                txtDepoYeri.Text = data.First().DepoYeri;
                txtMalzemeKısaMetni.Text = data.First().MalzemeKısaMetni;
                txtDepoAdresi.Text = data.First().DepoAdresi;
                txtEmniyetStogu.Text = data.First().EmliyetStogu;
                txtGuncellemeTarihi.Text = data.First().GuncellemeTarihi.ToString();
                txtGuncelleyenKullanici.Text = data.First().GuncelleyenKullanici;
                txtKaydedenKullanici.Text = data.First().KaydedenKullanici;
                txtKayitTarihi.Text = Convert.ToString(data.First().KayitTarihi);
                txtMalzemeKodu.Text = Convert.ToString(data.First().MalzemeKodu);
                txtMipPartiBuyuklugu.Text = data.First().MIPPartiBuyuklugu;
                txtUretimDenetimProfili.Text = data.First().UretimDenetimProfii;
                txtUretimDenetimSorumlusu.Text = data.First().UretimDenetimSorumlusu;
                ddlMalGrubu.SelectedValue = data.First().IdMalGrubu.ToString();
                ddlMalzemeTuru.SelectedValue = data.First().IdMalzemeTuru.ToString();
                ddlMIPKarakteristigi.SelectedValue = data.First().IdMIPKarakteristligi.ToString();
                ddlMipSorumlusu.SelectedValue = data.First().IdMIPSorumlusu.ToString();
                ddlTedarikTuru.SelectedValue = data.First().IdTedarikTuru.ToString();
                ddlTemelOlcuBirimi.SelectedValue = data.First().IdTemelOlcuBirimi.ToString();
                ddlUretimYeri.SelectedValue = data.First().IdUretimYeri.ToString();
                ddlOnayDurum.SelectedValue = Convert.ToString(data.First().IdOnayDurumu);
                //verileri tablodan foldurma
            }



        }


        #region Binding
        private void BindOnayDurum()
        {
            var data = from dd in dc.tOnayDurums select dd;

            ddlOnayDurum.DataSource = data;
            ddlOnayDurum.DataBind();
        }
        private void BindMalzemeTuru()
        {
            var data = from dd in dc.tMlzTurleris select dd;
            ddlMalzemeTuru.DataSource = data;
            ddlMalzemeTuru.DataBind();
        }

        private void BindTemelOlcuBirimi()
        {
            var data = from dd in dc.tTOBs select dd;
            ddlTemelOlcuBirimi.DataSource = data;
            ddlTemelOlcuBirimi.DataBind();
        }

        private void BindMalGrubu()
        {
            var data = from dd in dc.tMalGrubus select dd;
            ddlMalGrubu.DataSource = data;
            ddlMalGrubu.DataBind();
        }

        private void BindMIPKrk()
        {
            var data = from dd in dc.tMipKrks select dd;
            ddlMIPKarakteristigi.DataSource = data;
            ddlMIPKarakteristigi.DataBind();
        }

        private void BindMIPSorumlusu()
        {
            var data = from dd in dc.tMipSrmlus select dd;
            ddlMipSorumlusu.DataSource = data;
            ddlMipSorumlusu.DataBind();
        }
        private void BindTedarikTuru()
        {
            var data = from dd in dc.tTdrkTurus select dd;
            ddlTedarikTuru.DataSource = data;
            ddlTedarikTuru.DataBind();

        }

        private void BindUretimYeri()
        {
            var data = from dd in dc.tUYs select dd;
            ddlUretimYeri.DataSource = data;
            ddlUretimYeri.DataBind();
        }



        #endregion

        //aslında verıler kayıtlı gelıcek kaydete gerek yok

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtMalzemeKodu.Text))
            //{
            //    var varmi = dc.tMlzGenels.SingleOrDefault(deger => deger.MalzemeKodu.ToString() == txtMalzemeKodu.Text);
            //    Response.Write("<script>alert('Veri Önceden Kayıtlı')</script>");
            //                }
            tMlzGenel genel = new tMlzGenel
            {
                MalzemeKodu = Convert.ToInt32(txtMalzemeKodu.Text),
                IdMalzemeTuru = Convert.ToInt32(ddlMalzemeTuru.Text),
                IdUretimYeri = Convert.ToInt32(ddlUretimYeri.Text),
                DepoYeri = txtDepoYeri.Text,
                MalzemeKısaMetni = txtMalzemeKısaMetni.Text,
                IdTemelOlcuBirimi = Convert.ToInt32(ddlTemelOlcuBirimi.Text),
                IdMalGrubu = Convert.ToInt32(ddlMalGrubu.Text),
                IdMIPKarakteristligi = Convert.ToInt32(ddlMIPKarakteristigi.Text),
                IdMIPSorumlusu = Convert.ToInt32(ddlMipSorumlusu.Text),
                MIPPartiBuyuklugu = txtMipPartiBuyuklugu.Text,
                IdTedarikTuru = Convert.ToInt32(ddlTedarikTuru.Text),
                UretimDenetimSorumlusu = txtUretimDenetimSorumlusu.Text,
                UretimDenetimProfii = txtUretimDenetimProfili.Text,
                DepoAdresi = txtDepoAdresi.Text,
                EmliyetStogu = txtEmniyetStogu.Text,
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                IdOnayDurumu = Convert.ToInt32(ddlOnayDurum.Text)

            };
            dc.tMlzGenels.InsertOnSubmit(genel);
            dc.SubmitChanges();

        }

        protected void btnSatinAlma_Click(object sender, EventArgs e)
        {
            Response.Redirect("SatinAlma.aspx");
        }

        protected void btnFinans_Click(object sender, EventArgs e)
        {
            Response.Redirect("MalzemeFinans.aspx");
        }

        private void updateOnay()
        {
            int statu = Convert.ToInt32(Session["UserStatu"]);
            if (statu == 4)
            {
                Response.Write("<script>alert('Tüm Bölümlerde Onaylandı Ve Sisteme Girildi')</script>");
            }
            else
            {
                int a = int.Parse((ddlOnayDurum.SelectedItem.Value));
                a++;
                //sorgu ile update işlemei yapıldı girilen malzeme koduna gore secıp guncellenmesi sağlanıyor
                var gg = dc.tMlzGenels.SingleOrDefault(onay => onay.MalzemeKodu == Convert.ToInt32(txtMalzemeKodu.Text));
                gg.IdOnayDurumu = a;
                dc.SubmitChanges();

                ddlOnayDurum.SelectedValue = a.ToString();
                ddlOnayDurum.Text = a.ToString();
                btnOnay.Visible = false;
            }
        }
        protected void btnOnay_Click(object sender, EventArgs e)
        {
            updateOnay();

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            int statu = Convert.ToInt32(Session["UserStatu"]);

            // herkese tektek yapmadım e mail yok diye 

            MailMessage mail = new MailMessage(); // mail adında MailMessage nesnesi yaratıyoruz.
            mail.From = new MailAddress("ozge.coskun0110@gmail.com"); //Mailin kimden gittiğini belirtiyoruz
            mail.To.Add("coskun.ozgee@gmail.com"); //Mailin kime gideceğini belirtiyoruz
            mail.Subject = "Onayınızda Malzeme Var"; //Mail konusu
            if (statu == 1)
            {
                mail.Body = "AR-GE'den onayınızda bekleyen malzeme var iyi çalışmlar..."; //Mailin içeriği
            }
            else if (statu == 2)
            {
                mail.Body = "Satın Alma Bölümün'den onayınızda bekleyen malzeme var iyi çalışmlar..."; //Mailin içeriği
            }
            else if (statu == 3)
            {
                mail.Body = "Finans Bölümün'den onayınızda bekleyen malzeme var iyi çalışmlar..."; //Mailin içeriği
            }

            SmtpClient sc = new SmtpClient(); //sc adında SmtpClient nesnesi yaratıyoruz.
            sc.Port = 587; //Gmail için geçerli Portu bildiriyoruz
            sc.Host = "smtp.gmail.com"; //Gmailin smtp host adresini belirttik
            sc.EnableSsl = true; //SSL’i etkinleştirdik.
            sc.Credentials = new NetworkCredential("ozge.coskun0110@gmail.com", "11101110"); //Gmail hesap kontrolü için bilgilerimizi girdik
            sc.Send(mail); //Mailinizi gönderiyoruz.

        }


    }





}















