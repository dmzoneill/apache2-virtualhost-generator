Imports System.IO

Module Module1

    Sub Main()
        Dim fs As New FileStream("C:\apache2triad\conf\virtual-hosts.conf", FileMode.Create, FileAccess.Write)
        'declaring a FileStream and creating a document file named file with
        'access mode of writing
        Dim s As New StreamWriter(fs)
        Dim di As New IO.DirectoryInfo("F:\Stuff\dave\websites")
        Dim diar1 As IO.DirectoryInfo() = di.GetDirectories()

        Dim dra As IO.DirectoryInfo

        s.WriteLine("NameVirtualHost *:80")
        s.WriteLine(vbNewLine)
        For Each dra In diar1
            Dim url, name As String
            url = "DocumentRoot ""F:\Stuff\dave\websites\" + dra.Name + """"
            name = "ServerName " + dra.Name + ".localhost"
            s.WriteLine("<VirtualHost *:80>")
            s.WriteLine(url)
            s.WriteLine(name)
            s.WriteLine("DirectoryIndex index.php index.html index.html index.htm index.shtml")
            s.WriteLine("Options Indexes FollowSymLinks +Includes ExecCGI")
            s.WriteLine("</VirtualHost>")
            s.WriteLine(vbNewLine)
            System.Console.Write("Added new subdomain : " + dra.Name + vbNewLine)

            s.WriteLine("<Directory ""F:\Stuff\dave\websites\" + dra.Name + """>")
            s.WriteLine("Options Indexes FollowSymLinks +Includes ExecCGI")
            s.WriteLine("AllowOverride All")
            s.WriteLine("Order allow,deny")
            s.WriteLine("Allow from all")
            s.WriteLine("</Directory>")

        Next


        s.WriteLine("<VirtualHost *:80>")
        s.WriteLine("DocumentRoot ""C:/apache2triad/htdocs""")
        s.WriteLine("ServerName localhost")
        s.WriteLine("</VirtualHost> ")
        s.Close()

        Dim fss As New FileStream("C:\WINDOWS\system32\drivers\etc\hosts", FileMode.Create, FileAccess.Write)
        'declaring a FileStream and creating a document file named file with
        'access mode of writing
        Dim ss As New StreamWriter(fss)
        Dim dis As New IO.DirectoryInfo("F:\Stuff\dave\websites")
        Dim diar1s As IO.DirectoryInfo() = dis.GetDirectories()
        Dim dras As IO.DirectoryInfo

        For Each dras In diar1s
            ss.WriteLine("127.0.0.1     " + dras.Name + ".localhost")
            System.Console.Write("Added host file entry for subdomain : " + dras.Name + vbNewLine)
        Next

        ss.WriteLine("127.0.0.1 localhost")
        ss.Close()

    End Sub

End Module
