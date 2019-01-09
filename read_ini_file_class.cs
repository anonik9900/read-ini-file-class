//only for gta v mod template
//builded for personal-use

void onTick(object sender, EventArgs e)
        {
            if (modMenuPool != null)
                modMenuPool.ProcessMenus();
        }

        void onKeyDown(object sender, KeyEventArgs e)
        {
            GTA.ScriptSettings configkey; //set the 'configkey' variable as a GTA.ScriptsSettings var-type
            Keys OpenMenu; //set 'OpenMenu' as System.Windows.Forms.Keys var-type
 
            configkey = ScriptSettings.Load("scripts\\essentialconfig.ini"); //load the .ini file in the scripts folder
            OpenMenu = configkey.GetValue<Keys>("Options", "OpenMenu", Keys.Z); //The Z key will be set my default, but the user can change the key

            if (e.KeyCode == OpenMenu && !modMenuPool.IsAnyMenuOpen()) //read the .ini file and get the key to open the mod menu
            {
                mainMenu.Visible = !mainMenu.Visible;

		//code here

            }
        }