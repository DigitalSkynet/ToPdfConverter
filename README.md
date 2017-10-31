### Adding to the righ click menu

Open regedit and go to HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\ and create new Key, name it "Convert To Pdf"
then create another Key "commmand" for "Convert To Pdf" 

In "command" key update default value and set the path to "<Full path to git folder>/build/ImagesToPdf.exe %1"

So finally you should have the value set for the key:
\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\Convert To Pdf\command

Default value should be like: "D:\Work\ImagesToPdf\build\ImagesToPdf.exe %1"

### License information

If you want to share your work with others, please consider choosing an open
source license and include the text of the license into your project.
The text of a license is usually stored in the `LICENSE` (or `LICENSE.txt`,
`LICENSE.md`) file in the root of the project.

> You’re under no obligation to choose a license and it’s your right not to
> include one with your code or project. But please note that opting out of
> open source licenses doesn’t mean you’re opting out of copyright law.
> 
> You’ll have to check with your own legal counsel regarding your particular
> project, but generally speaking, the absence of a license means that default
> copyright laws apply. This means that you retain all rights to your source
> code and that nobody else may reproduce, distribute, or create derivative
> works from your work. This might not be what you intend.
>
> Even in the absence of a license file, you may grant some rights in cases
> where you publish your source code to a site that requires accepting terms
> of service. For example, if you publish your source code in a public
> repository on GitHub, you have accepted the [Terms of Service](https://help.github.com/articles/github-terms-of-service)
> which do allow other GitHub users some rights. Specifically, you allow others
> to view and fork your repository.

For more info on how to choose a license for an open source project, please
refer to http://choosealicense.com