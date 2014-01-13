# ConvertToF3i18n #
This VERY simply little Windows tool was quickly thrown together to assist in the multilingual support conversion INI files for the PHP [FatFreeFramework](http://fatfreeframework.com/views-and-templates#multilingual-support).

- Paste in your regular text strings, and click Convert. The tool will then create a variable out of each string and convert it all to the F3 language ini file format.
- You will then be able to append the conversion to an existing ini file, or you can just copy/paste if you prefer
- You can also paste in any html template code you have and it can replace all the regular text strings with the variables from the conversion.

It does nothing you can't do by hand, but I wrote it quickly for myself to save a little time and effort in my language ini file conversions. I'm just sharing it here in case it can do the same for others.

It's built in Visual Studio 2012 and compiled against .NET 3.5. I've only tested it on my Windows 8 machine and against some basic strings and template files.

The source is in the Source directory and the single executable is in the Dist directory.

Here's a quick screenshot...
![](http://i.imgur.com/QOpyDBR.jpg)