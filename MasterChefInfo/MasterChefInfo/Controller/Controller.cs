﻿using MasterChefInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe du controlleur
    /// </summary>
    class Controller
    {
        public Model model;
        public DinnerRoomController dinnerRoomController;
        public ClientGeneratorController clientGeneratorController;
        public ViewController viewController;
        public Form1 form;

        public Controller()
        {
            model = new Model();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form1(model);

            dinnerRoomController = new DinnerRoomController(model);

            SetObserver();

            InvalidOperationException e = null;

                try
                {
                lock (form)
                {
                    Application.Run(form);
                }
                    e = null;
                }
                catch (InvalidOperationException ex)
                {
                    e = ex;
                Console.WriteLine(e);
                }
        }

        public void SetObserver()
        {
            foreach (Square square in model.dinnerRoom.squares)
            {
                foreach (Waiter waiter in square.waiters)
                {
                    waiter.RegisterObserver(form);
                }

                square.squareSupervisor.RegisterObserver(form);
            }

            foreach (SectionChef sectionChef in model.kitchen.cookingRoom.masterChef.sectionChefs)
            {
                sectionChef.RegisterObserver(form);
            }

            model.dinnerRoom.maitreHotel.RegisterObserver(form);
        }
    }

}
