# Monobehaviour Templates

Templates to replace Unity's default template for new C# scripts.

Under the following path:

> *C:\Program Files\Unity\Hub\Editor\"Editor version folder"\Editor\Data\Resources\ScriptTemplates\\*  

You will find a file named:  

> *81-C# Script-NewBehaviourScript.cs.txt*

Replace the content of this file with the content of any file under *Templates* and save.

Now, the standard Monobehaviour script template is changed when creating new scripts.  

When using the *NamespaceTemplate*, the script `ScriptTemplateKeywordReplacer.cs` will exchange `#PROJECTNAME#` for the project's name, simulating the act of moving the class to a namespace.
