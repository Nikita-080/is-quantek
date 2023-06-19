﻿using InformSystem.dataBase;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem.Forms
{
    public partial class PCInformForm : Form
    {
        int id_PC;
        int building;
        int floor;
        int office;
        private dataBase.Hardware PC;
        private dataBase.Place place;
        private dataBase.Access access;

        private void LoadPCInfo(int id)
        {
            id_PC = id;
            try
            {
                PnppkContext context = new PnppkContext();
                PC = context.Hardwares.Select(pc => pc).Where(pc => pc.IdH == id).First();
                place = context.Places.Select(p => p).Where(p => p.HardwareP == id).FirstOrDefault();
                access = context.Accesses.Select(pers => pers).Where(pers => pers.HardwareA == id).FirstOrDefault();
                IdTextBox.Text = PC.IdH.ToString();
                HTypeTextBox.Text = "Компьютер";
                if (place != null)
                {
                    PlaceTextBox.Text = "Здание " + place.Building + ", " + "этаж " + place.Floor + ", " + "офис " + place.Office;
                    int idD = place.DepartmentId;
                    dataBase.DepartmentDict department = context.DepartmentDicts.Select(d => d).Where(d => d.IdDd == idD).FirstOrDefault();
                    departmenTextBox.Text = department.NameD;
                }
                if (access != null)
                {
                    PersonTextBox.Text = access.Person.ToString();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public PCInformForm(int idPC)
        {
            InitializeComponent();
            ActiveElementsChange();
            LoadPCInfo(idPC);
            ConfigLoad(idPC);

        }
        private void ActiveElementsChange()
        {
            HTypeTextBox.Enabled = false;
            PlaceTextBox.Enabled = true;
            PersonTextBox.Enabled = true;
            departmenTextBox.Enabled = true;
        }
        private void ConfigLoad(int id)
        {
            try
            {
                using (PnppkContext context = new PnppkContext())
                {
                    var config = from hardw in context.HardwareValues
                                 join prop in context.HardwareProperties on hardw.Property equals prop.IdHp
                                 where hardw.HardwareV == id
                                 orderby hardw.Property
                                 select new
                                 {
                                     name = prop.NameP,
                                     value = hardw.Value
                                 };
                    var disk = from d in context.Disks
                               where d.HardwareD == id
                               select new
                               {
                                   name = "Диск",
                                   value = d.Size + "GB " + d.Creator + " " + d.Model + " (" + d.Type + ")"
                               };
                    //dataGridViewPcInfo.DataSource = config.ToList();
                    foreach (var c in config.ToList())
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridViewPcInfo);
                        dr.Cells[0].Value = c.name;
                        dr.Cells[1].Value = c.value;
                        dataGridViewPcInfo.Rows.Add(dr);
                    }
                    foreach (var d in disk.ToList())
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dataGridViewPcInfo);
                        dr.Cells[0].Value = d.name;
                        dr.Cells[1].Value = d.value;
                        dataGridViewPcInfo.Rows.Add(dr);
                    }



                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCInformForm_Load(object sender, EventArgs e)
        {

        }

        private void editPlaceButton_Click(object sender, EventArgs e)
        {
            ChangePlaceForm placeC = new ChangePlaceForm();
            placeC.ShowDialog();
            if (placeC.Save) //if click save button
            {
                building = Convert.ToInt32(placeC.Building);
                floor = Convert.ToInt32(placeC.Floor);
                office = Convert.ToInt32(placeC.Office);
                PlaceTextBox.Text = "Здание " + placeC.Building + ", " + "этаж " + placeC.Floor + ", " + "офис " + placeC.Office;
            }
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            ChangePersonForm person = new ChangePersonForm();
            person.ShowDialog();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO Сохранение данных системного блока оборудования
            PnppkContext context = new PnppkContext();
            place = context.Places.Select(h => h).Where(h => h.HardwareP == id_PC).First();
            place.Building = building;
            place.Floor = floor;
            place.Office = office;
            access = context.Accesses.Where(a => a.HardwareA == id_PC).First();
            access.Person = Convert.ToInt32(PersonTextBox.Text);
            context.SaveChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPeripheryForm periphery = new AddPeripheryForm(PC.IdH);
            periphery.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}