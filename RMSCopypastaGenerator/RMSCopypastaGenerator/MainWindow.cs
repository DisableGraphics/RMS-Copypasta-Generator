using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Create(object sender, EventArgs e)
    {
        this.Title = "RMS Copypasta Generator --- " + entry1.Text + "/" + entry2.Text;
        textview1.Buffer.Text += "I'd just like to interject for a moment.\nWhat you’re referring to as " + entry2.Text +",  is in fact," + entry1.Text + "/" + entry2.Text + ", or as I’ve recently taken to calling it, " + entry1.Text + " plus " + entry2.Text + ".\n";
        textview1.Buffer.Text += entry2.Text + " is not an operating system unto itself, but rather another free component of a fully functioning " + entry1.Text + " system made useful by the " + entry1.Text + " corelibs, shell utilities and vital system components comprising a full OS as defined by POSIX.\nMany computer users run a modified version of the " + entry1.Text;
        textview1.Buffer.Text += " system every day, without realizing it.\nThrough a peculiar turn of events, the version of " + entry1.Text + " which is widely used today is often called “" + entry2.Text + "”, and many of its users are not aware that it is basically the " + entry1.Text;
        textview1.Buffer.Text += " system, developed by the " + entry1.Text + " Project.\nThere really is a " + entry2.Text + ", and these people are using it, but it is just a part of the system they use.\n" + entry2.Text;
        textview1.Buffer.Text += " is the kernel: the program in the system that allocates the machine’s resources to the other programs that you run.\nThe kernel is an essential part of an operating system, but useless by itself; it can only function in the context of a complete operating system.\n" + entry2.Text + " is normally used in combination with the " + entry1.Text;
        textview1.Buffer.Text += " operating system: the whole system is basically " + entry1.Text + " with " + entry2.Text + " added, or " + entry1.Text + "/" + entry2.Text + ".\nAll the so-called " + "“" + entry2.Text + "”" + " distributions are really distributions of " + entry1.Text + "/" + entry2.Text + ".";
    }
}
