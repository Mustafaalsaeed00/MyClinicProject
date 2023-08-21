using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ClinicBusinessLayer;


namespace The_Clinic
{
    public partial class MainUserInterface : KryptonForm
    {
        clsUser _CurrentUser;

        bool _UserLogedOut = false;

        enum enPermissions { eAll = -1, ePatient = 1, eDoctor = 2, eAppointment = 4, ePayment = 8, eUser = 16 }

        private bool SidebarExpand;
        private bool PatientContainerExpand = true;
        private bool DoctorContainerExpand = true;
        private bool AppointmentContainerExpand = true;
        private bool PaymentContainerExpand = true;
        private bool UserContainerExpand = true;

        private Button CurrentButton;
        private Random random;
        private int tempIndex;
        Color _Color;

        //this Constructor to Get the CurrentUser and check the permissions
        public MainUserInterface(clsUser User)
        {
            InitializeComponent();
            random = new Random();
            _CurrentUser = User;
            if (!CheckAccessPermissions(enPermissions.eAll))
            {
                btnPatient.Enabled = CheckAccessPermissions(enPermissions.ePatient);
                btnDoctor.Enabled = CheckAccessPermissions(enPermissions.eDoctor);
                btnAppointment.Enabled = CheckAccessPermissions(enPermissions.eAppointment);
                btnPayment.Enabled = CheckAccessPermissions(enPermissions.ePayment);
                btnUser.Enabled = CheckAccessPermissions(enPermissions.eUser);
            }
        }

        private void MainUserInterface_Load(object sender, EventArgs e)
        {
            _HomeScreenClock();

            _NavigatorPagesVisible(false);
            //foreach (Control ctrl in this.Controls)
            //{
            //
            //    if (ctrl is MdiClient)
            //    {
            //        ctrl.BackColor = Color.Azure;
            //    }
            //}
        }

        private void _HomeScreenClock()
        {
            HomeScreenClock.Start();
            lblDate.Text = DateTime.Now.ToString("d");
        }

        private void _NavigatorPagesVisible(bool Visible)
        {
            FindPatient.Visible = Visible;
            AddPatient.Visible = Visible;
            UpdatePatient.Visible = Visible;
            PatientsList.Visible = Visible;
            FindDoctor.Visible = Visible;
            AddDoctor.Visible = Visible;
            UpdateDoctor.Visible = Visible;
            DoctorsList.Visible = Visible;
            FindAppointment.Visible = Visible;
            AddAppointment.Visible = Visible;
            UpdateAppointment.Visible = Visible;
            AppointmentsList.Visible = Visible;
            UpdatePayment.Visible = Visible;
            PaymentsList.Visible = Visible;
            AddUser.Visible = Visible;
            UpdateUser.Visible = Visible;
            UsersList.Visible = Visible;
            Settings.Visible = Visible;
        }

        private bool CheckAccessPermissions(enPermissions Permissions)
        {
            if (_CurrentUser.Permissions == (int)enPermissions.eAll)
                return true;

            if (((int)Permissions & _CurrentUser.Permissions) == (int)Permissions)
            {
                return true;
            }

            return false;
        }

        private bool MinimizePatientContainer()
        {
            PatientContainer.Height -= 10;
            if (PatientContainer.Height == PatientContainer.MinimumSize.Height)
            {
                PatientContainerExpand = true;
                PatientTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MinimizeDoctorContainer()
        {
            DoctorContainer.Height -= 10;
            if (DoctorContainer.Height == DoctorContainer.MinimumSize.Height)
            {
                DoctorContainerExpand = true;
                DoctorTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MinimizeAppointmentContainer()
        {
            AppointmentContainer.Height -= 10;
            if (AppointmentContainer.Height == AppointmentContainer.MinimumSize.Height)
            {
                AppointmentContainerExpand = true;
                AppointmentTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MinimizePaymentContainer()
        {
            PaymentContainer.Height -= 10;
            if (PaymentContainer.Height == PaymentContainer.MinimumSize.Height)
            {
                PaymentContainerExpand = true;
                PaymentTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MinimizeUserContainer()
        {
            UserContainer.Height -= 10;
            if (UserContainer.Height == UserContainer.MinimumSize.Height)
            {
                UserContainerExpand = true;
                UserTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MaximizePatientContainer()
        {
            PatientContainer.Height += 10;
            if (PatientContainer.Height == PatientContainer.MaximumSize.Height)
            {
                PatientContainerExpand = false;
                PatientTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MaximizeDoctorContainer()
        {
            DoctorContainer.Height += 10;
            if (DoctorContainer.Height == DoctorContainer.MaximumSize.Height)
            {
                DoctorContainerExpand = false;
                DoctorTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MaximizeAppointmentContainer()
        {
            AppointmentContainer.Height += 10;
            if (AppointmentContainer.Height == AppointmentContainer.MaximumSize.Height)
            {
                AppointmentContainerExpand = false;
                AppointmentTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MaximizePaymentContainer()
        {
            PaymentContainer.Height += 10;
            if (PaymentContainer.Height == PaymentContainer.MaximumSize.Height)
            {
                PaymentContainerExpand = false;
                PaymentTimer.Stop();
                return true;
            }
            return false;
        }

        private bool MaximizeUserContainer()
        {
            UserContainer.Height += 10;
            if (UserContainer.Height == UserContainer.MaximumSize.Height)
            {
                UserContainerExpand = false;
                UserTimer.Stop();
                return true;
            }
            return false;
        }

        private void HomeScreenClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    SidebarExpand = false;
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void PatientTimer_Tick(object sender, EventArgs e)
        {
            if (PatientContainerExpand)
                MaximizePatientContainer();
            else
                MinimizePatientContainer();
        }

        private void DoctorTimer_Tick(object sender, EventArgs e)
        {
            if (DoctorContainerExpand)
                MaximizeDoctorContainer();
            else
                MinimizeDoctorContainer();
        }

        private void AppointmentTimer_Tick(object sender, EventArgs e)
        {
            if (AppointmentContainerExpand)
                MaximizeAppointmentContainer();

            else
                MinimizeAppointmentContainer();
        }

        private void PaymentTimer_Tick(object sender, EventArgs e)
        {
            if (PaymentContainerExpand)
                MaximizePaymentContainer();
            else
                MinimizePaymentContainer();
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            if (UserContainerExpand)
                MaximizeUserContainer();
            else
                MinimizeUserContainer();
        }

        private void _SetHeaderFormat(string Name, Image image , Color color)
        {
            lblHeader.Text = Name;
            pbHeader.Image = image;
            lblHeader.BackColor = color;
            pbHeader.BackColor = color;
        }

        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void _SetThemeColor(Color color)
        {
            lblHeader.BackColor = color;
            CurrentButton.BackColor = color;
            pnlHomeScreen.BackColor = color;
        }

        public void ActiveButton(object sender)
        {
            if (sender != null)
            {
                if (CurrentButton != (Button)sender)
                {
                    DisableButton();
                    _Color = selectThemeColor();
                    CurrentButton = (Button)sender;
                    _SetThemeColor(_Color);
                }
            }
        }

        private void DisableButton()
        {
            List<Control> controls = new List<Control>()
            {
                btnHome,
                btnPatient,btnAddPatient , btnFindPatient , btnUpdatePatient ,  btnGetAllPatients,
                btnDoctor,btnAddDoctor , btnFindDoctor , btnUpdateDoctor ,  btnGetAllDoctors,
                btnAppointment,btnNewAppointment ,btnFindAppointment, btnUpdateAppointment ,btnAllAppointments,
                btnPayment  , btnUpdatePayment , btnPaymentsList ,
                btnUser , btnAddUser , btnUpdateUser, btnUsersList,
                btnSettings
            };

            foreach (Control PreviousButton in controls)
            {
                if (PreviousButton.GetType() == typeof(Button))
                {
                    PreviousButton.BackColor = Color.Black;
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            if (PatientContainerExpand == false)
            {
                PatientTimer.Start();
            }

            if (DoctorContainerExpand == false)
            {
                DoctorTimer.Start();

            }

            if (AppointmentContainerExpand == false)
            {
                AppointmentTimer.Start();
            }

            if (UserContainerExpand == false)
            {
                UserTimer.Start();
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("Home", Properties.Resources.home_button , btnHome.BackColor);

            pnlHomeScreen.Visible = true;

            if (PatientContainerExpand == false)
                PatientTimer.Start();

            if (DoctorContainerExpand == false)
                DoctorTimer.Start();

            if (AppointmentContainerExpand == false)
                AppointmentTimer.Start();

            if (PaymentContainerExpand == false)
                PaymentTimer.Start();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("Patient", Properties.Resources.patient, btnPatient.BackColor);

            pnlHomeScreen.Visible = false;

            PatientTimer.Start();

            if (DoctorContainerExpand == false)
                DoctorTimer.Start();

            if (AppointmentContainerExpand == false)
                AppointmentTimer.Start();

            if (PaymentContainerExpand == false)
                PaymentTimer.Start();

            if (UserContainerExpand == false)
                UserTimer.Start();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("Doctor", Properties.Resources.doctor, btnDoctor.BackColor);

            pnlHomeScreen.Visible = false;

            DoctorTimer.Start();

            if (PatientContainerExpand == false)
                PatientTimer.Start();

            if (AppointmentContainerExpand == false)
                AppointmentTimer.Start();

            if (PaymentContainerExpand == false)
                PaymentTimer.Start();

            if (UserContainerExpand == false)
                UserTimer.Start();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("Appointment", Properties.Resources.appointment , btnAppointment.BackColor);

            pnlHomeScreen.Visible = false;

            AppointmentTimer.Start();

            if (PatientContainerExpand == false)
                PatientTimer.Start();

            if (DoctorContainerExpand == false)
                DoctorTimer.Start();

            if (PaymentContainerExpand == false)
                PaymentTimer.Start();

            if (UserContainerExpand == false)
                UserTimer.Start();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("Payment", Properties.Resources.deposit__3_ , btnPayment.BackColor);

            pnlHomeScreen.Visible = false;

            PaymentTimer.Start();

            if (PatientContainerExpand == false)
                PatientTimer.Start();

            if (DoctorContainerExpand == false)
                DoctorTimer.Start();

            if (AppointmentContainerExpand == false)
                AppointmentTimer.Start();

            if (UserContainerExpand == false)
                UserTimer.Start();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("User", Properties.Resources.hacker__3_ , btnUser.BackColor);

            pnlHomeScreen.Visible = false;

            UserTimer.Start();

            if (PatientContainerExpand == false)
                PatientTimer.Start();

            if (DoctorContainerExpand == false)
                DoctorTimer.Start();

            if (AppointmentContainerExpand == false)
                AppointmentTimer.Start();

            if (PaymentContainerExpand == false)
                PaymentTimer.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
               ActiveButton(sender);
               _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnSettings.BackColor);

               pnlHomeScreen.Visible = false;

               if (PatientContainerExpand == false)
                   PatientTimer.Start();

               if (DoctorContainerExpand == false)
                   DoctorTimer.Start();

               if (AppointmentContainerExpand == false)
                   AppointmentTimer.Start();

               if (PaymentContainerExpand == false)
                   PaymentTimer.Start();

               if (UserContainerExpand == false)
                   UserTimer.Start();

            if (Settings.Visible == false)
            {
                Settingsfrm frm = new Settingsfrm(btnSettings.BackColor, "Settings", Properties.Resources.settings1, _CurrentUser, this);
                frm.MdiParent = this;
                frm.TopLevel = false;
                Settings.Controls.Add(frm);
                Settings.Visible = true;
                HomeTab.SelectedPage = Settings;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = Settings;

        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnFindPatient.BackColor);

            if (FindPatient.Visible == false)
            {
                FindPatientfrm frm = new FindPatientfrm(btnFindPatient.BackColor, "Find Patient", Properties.Resources.FindPatient);
                frm.MdiParent = this;
                frm.TopLevel = false;
                FindPatient.Controls.Add(frm);
                FindPatient.Visible = true;
                HomeTab.SelectedPage = FindPatient;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = FindPatient;

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnAddPatient.BackColor);

            if (AddPatient.Visible == false)
            {
                AddNewPatientfrm frm = new AddNewPatientfrm(btnAddPatient.BackColor, "Add Patient", Properties.Resources.AddPatient);
                frm.MdiParent = this;
                frm.TopLevel = false;
                AddPatient.Controls.Add(frm);
                AddPatient.Visible = true;
                HomeTab.SelectedPage = AddPatient;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = AddPatient;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnUpdatePatient.BackColor);

            if (UpdatePatient.Visible == false)
            {
                UpdatePatientfrm frm = new UpdatePatientfrm(btnUpdatePatient.BackColor, "UpdatePaitent", Properties.Resources.UpdatePatient);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UpdatePatient.Controls.Add(frm);
                UpdatePatient.Visible = true;
                HomeTab.SelectedPage = UpdatePatient;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UpdatePatient;
        }

        private void btnGetAllPatients_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnGetAllPatients.BackColor);

            if (PatientsList.Visible == false)
            {
                AllPatientsfrm frm = new AllPatientsfrm(btnGetAllPatients.BackColor, "All Patients", Properties.Resources.allPatients);
                frm.MdiParent = this;
                frm.TopLevel = false;
                PatientsList.Controls.Add(frm);
                PatientsList.Visible = true;
                HomeTab.SelectedPage = PatientsList;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = PatientsList;
        }

        private void btnFindDoctor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnFindDoctor.BackColor);

            if (FindDoctor.Visible == false)
            {
                FindDoctorfrm frm = new FindDoctorfrm(btnFindDoctor.BackColor, "Find Doctor", Properties.Resources.FindDoctor);
                frm.MdiParent = this;
                frm.TopLevel = false;
                FindDoctor.Controls.Add(frm);
                FindDoctor.Visible = true;
                HomeTab.SelectedPage = FindDoctor;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = FindDoctor;
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnAddDoctor.BackColor);

            if (AddDoctor.Visible == false)
            {
                AddNewDoctorfrm frm = new AddNewDoctorfrm(btnAddDoctor.BackColor, "Add Doctor", Properties.Resources.AddDoctor);
                frm.MdiParent = this;
                frm.TopLevel = false;
                AddDoctor.Controls.Add(frm);
                AddDoctor.Visible = true;
                HomeTab.SelectedPage = AddDoctor;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = AddDoctor;
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic,btnUpdateDoctor.BackColor);

            if (UpdateDoctor.Visible == false)
            {
                UpdateDoctorfrm frm = new UpdateDoctorfrm(btnUpdateDoctor.BackColor, "Update Doctor", Properties.Resources.UpdateDoctor);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UpdateDoctor.Controls.Add(frm);
                UpdateDoctor.Visible = true;
                HomeTab.SelectedPage = UpdateDoctor;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UpdateDoctor;
        }

        private void btnGetAllDoctors_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnGetAllDoctors.BackColor);

            if (DoctorsList.Visible == false)
            {
                AllDoctorsfrm frm = new AllDoctorsfrm(btnGetAllDoctors.BackColor, "All Doctors", Properties.Resources.AllDoctors);
                frm.MdiParent = this;
                frm.TopLevel = false;
                DoctorsList.Controls.Add(frm);
                DoctorsList.Visible = true;
                HomeTab.SelectedPage = DoctorsList;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = DoctorsList;
        }

        private void btnFindAppointment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnFindAppointment.BackColor);

            if (FindAppointment.Visible == false)
            {
                FindAppointmentfrm frm = new FindAppointmentfrm(btnFindAppointment.BackColor, "Find Appointment", Properties.Resources.FindAppointment);
                frm.MdiParent = this;
                frm.TopLevel = false;
                FindAppointment.Controls.Add(frm);
                FindAppointment.Visible = true;
                HomeTab.SelectedPage = FindAppointment;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = FindAppointment;
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnNewAppointment.BackColor);

            if (AddAppointment.Visible == false)
            {
                AddNewAppointmentfrm frm = new AddNewAppointmentfrm(btnNewAppointment.BackColor, "New Appointment", Properties.Resources.AddAppointment);
                frm.MdiParent = this;
                frm.TopLevel = false;
                AddAppointment.Controls.Add(frm);
                AddAppointment.Visible = true;
                HomeTab.SelectedPage = AddAppointment;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = AddAppointment;
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnUpdateAppointment.BackColor);

            if (UpdateAppointment.Visible == false)
            {
                UpdateAppointmentfrm frm = new UpdateAppointmentfrm(btnUpdateAppointment.BackColor, "Update Appointment", Properties.Resources.UpdateAppointment);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UpdateAppointment.Controls.Add(frm);
                UpdateAppointment.Visible = true;
                HomeTab.SelectedPage = UpdateAppointment;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UpdateAppointment;
        }

        private void btnAllAppointments_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic, btnAllAppointments.BackColor);

            if (AppointmentsList.Visible == false)
            {
                AllAppointmentsfrm frm = new AllAppointmentsfrm(btnAllAppointments.BackColor, "All Appointments", Properties.Resources.AllAppointments);
                frm.MdiParent = this;
                frm.TopLevel = false;
                AppointmentsList.Controls.Add(frm);
                AppointmentsList.Visible = true;
                HomeTab.SelectedPage = AppointmentsList;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = AppointmentsList;
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnUpdatePayment.BackColor);

            if (UpdatePayment.Visible == false)
            {
                UpdatePaymentfrm frm = new UpdatePaymentfrm(btnUpdatePayment.BackColor, "Update Payment", Properties.Resources.Update_Payment__2_);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UpdatePayment.Controls.Add(frm);
                UpdatePayment.Visible = true;
                HomeTab.SelectedPage = UpdatePayment;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UpdatePayment;
        }

        private void btnPaymentsList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnPaymentsList.BackColor);

            if (PaymentsList.Visible == false)
            {
                AllPaymentsfrm frm = new AllPaymentsfrm(btnPaymentsList.BackColor, "All Payments", Properties.Resources.All_Payments__3_);
                frm.MdiParent = this;
                frm.TopLevel = false;
                PaymentsList.Controls.Add(frm);
                PaymentsList.Visible = true;
                HomeTab.SelectedPage = PaymentsList;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = PaymentsList;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnAddUser.BackColor);

            if (AddUser.Visible == false)
            {
                AddUserfrm frm = new AddUserfrm(btnAddUser.BackColor, "Add User", Properties.Resources.AddUser__2_);
                frm.MdiParent = this;
                frm.TopLevel = false;
                AddUser.Controls.Add(frm);
                AddUser.Visible = true;
                HomeTab.SelectedPage = AddUser;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = AddUser;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic  , btnUpdateUser.BackColor);

            if (UpdateUser.Visible == false)
            {
                UpdateUserfrm frm = new UpdateUserfrm(btnUpdateUser.BackColor, "Update User", Properties.Resources.UpdateUser__2_);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UpdateUser.Controls.Add(frm);
                UpdateUser.Visible = true;
                HomeTab.SelectedPage = UpdateUser;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UpdateUser;
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            _SetHeaderFormat("The Clinic", Properties.Resources.LogoClinic , btnUsersList.BackColor);

            if (UsersList.Visible == false)
            {
                AllUsersfrm frm = new AllUsersfrm(btnUsersList.BackColor, "All Users", Properties.Resources.UsersList__4_);
                frm.MdiParent = this;
                frm.TopLevel = false;
                UsersList.Controls.Add(frm);
                UsersList.Visible = true;
                HomeTab.SelectedPage = UsersList;
                frm.Show();
            }
            else
                HomeTab.SelectedPage = UsersList;

        }

        private void FindPatient_ControlRemoved(object sender, ControlEventArgs e)
        {
            FindPatient.Visible = false;
        }

        private void AddPatient_ControlRemoved(object sender, ControlEventArgs e)
        {
            AddPatient.Visible = false;
        }

        private void UpdatePatient_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdatePatient.Visible = false;
        }

        private void PatientsList_ControlRemoved(object sender, ControlEventArgs e)
        {
            PatientsList.Visible = false;
        }

        private void FindDoctor_ControlRemoved(object sender, ControlEventArgs e)
        {
            FindDoctor.Visible = false;
        }

        private void AddDoctor_ControlRemoved(object sender, ControlEventArgs e)
        {
            AddDoctor.Visible = false;
        }

        private void UpdateDoctor_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateDoctor.Visible = false;
        }

        private void DoctorsList_ControlRemoved(object sender, ControlEventArgs e)
        {
            DoctorsList.Visible = false;
        }

        private void FindAppointment_ControlRemoved(object sender, ControlEventArgs e)
        {
            FindAppointment.Visible = false;
        }

        private void AddAppointment_ControlRemoved(object sender, ControlEventArgs e)
        {
            AddAppointment.Visible = false;
        }

        private void UpdateAppointment_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateAppointment.Visible = false;
        }

        private void AppointmentsList_ControlRemoved(object sender, ControlEventArgs e)
        {
            AppointmentsList.Visible = false;
        }

        private void UpdatePayment_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdatePayment.Visible = false;
        }

        private void PaymentsList_ControlRemoved(object sender, ControlEventArgs e)
        {
            PaymentsList.Visible = false;
        }

        private void AddUser_ControlRemoved(object sender, ControlEventArgs e)
        {
            AddUser.Visible = false;
        }

        private void UpdateUser_ControlRemoved(object sender, ControlEventArgs e)
        {
            UpdateUser.Visible = false;
        }

        private void UsersList_ControlRemoved(object sender, ControlEventArgs e)
        {
            UsersList.Visible = false;
        }

        private void Settings_ControlRemoved(object sender, ControlEventArgs e)
        {
            Settings.Visible = false;
            if (_UserLogedOut)
                this.Close();
        }

        private void MainUserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsUserRegisteration register = new clsUserRegisteration();

            register.UserID = _CurrentUser.ID;
            register.dateTime = DateTime.Now;
            register.Description = "LogOut";
            register.Save();
        }
    }
}
