using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.Gateway;
using System.Windows.Forms;
using System.Drawing;

namespace CSharp_Selfbot
{
    public class varibles
    {
        public static int r = 180;
        public static int g = 15;
        public static int b = 255;
    }
    [Command("help")]
    public class help : CommandBase
    {
        public override void Execute()
        {
            
            try
            {
                if (Message.Author.User.Id == Client.User.Id)
                {
                    Message.Delete();
                    EmbedMaker embed = new EmbedMaker();
                    embed.Color = Color.FromArgb(varibles.r, varibles.g, varibles.b);
                    embed.Title =  "__Command List__";
                    embed.Description = $"Prefix: **{MainForm.prefix}**\nYour Command Go Here";
                    Message.Channel.SendMessage("", false, embed);
                }
            }
            catch
            {

            }
        }
    }
}
