# CustomizableForms
A C# WinForms library for Forms with a customizable header and border

How to install to your project:
-Open Microsoft Visual Studio and create/open a project
-Add reference to the file CustomizableForms.dll to your project

How to use:
-To create a Form with a customizable header and border, extend the class CustomizableForm:
```C#
public partial class YourFormName : CustomizableForms.CustomizableForm
```

Example for customizing a form:

```C#
CustomizableForms.CustomizableForm form = new CustomizableForms.CustomizableForm();
form.BorderColor = Color.Blue; // Changes form's border color to blue
form.Borderwidth = 2; // Sets form's border width to 2
form.DarkTheme = true; // Makes form dark
form.ShowTitle = false; // Hides form's title text from the header
form.Resizable = false; // Makes form not resizable
// And you can use these form's default properties to show/hide icon,minimize button, and maximizebutton:
form.MaximizeBox = false; // Hides maximize button
form.MinimizeBox = true;  // Shows minimize button
form.ShowIcon = false; // Hides icon from the form's header
// To change the form's header color:
form.formHeader.BackColor = Color.Navy; // Sets the header's color to Navy
```

-In the properties section for the form: Additional new properties are added:

![alt text](https://user-images.githubusercontent.com/50383558/159681299-b8c420ff-4327-4be4-89f2-5d408939b134.png)

Customized form examples:

Dark form

![alt text](https://user-images.githubusercontent.com/50383558/159679367-f9f23d08-9efc-4fc5-8705-990d2e21f33e.png)

Light form

![alt text](https://user-images.githubusercontent.com/50383558/159679412-2afea118-0d4b-49c0-80a0-91693d1e7985.png)

Form with custom header color

![alt text](https://user-images.githubusercontent.com/50383558/159679453-af780443-f63b-4041-9710-55add272c757.png)

Form with custom border color and width

![alt text](https://user-images.githubusercontent.com/50383558/159679525-57cbc59f-5d67-4b66-a0c8-a6b7f3d7b84e.png)

Enjoy! 
