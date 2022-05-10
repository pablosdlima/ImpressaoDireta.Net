# ImpressaoDireta.Net
Modelo de impressão direta para aplicações web Asp core. Processo nativo C#

## Captura de tela
![Print](https://github.com/pablosdlima/ImpressaoDireta.Net/blob/master/Imagem/Captura%20de%20tela%202022-05-06%20094733.png)


                    ### descrição dos comandos.
                    
                    UseShellExecute = true, //usa cmd | responsável por habilitar o metodo em asp core. Sem isso não funciona
                    CreateNoWindow = true, //define a impressão sem exibir tela de aviso. 
                    Verb = "printTo",     //responsável por imprimir.
                    Arguments = "\"" + printName + "\"", //responsável por apontar a impressora || printName == variavel que recebe o nome da impressora instalada no servidor
                    FileName = path, //caminho + arquivo || apenas arquivo
                    WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    
                    
                    
                    
                    ## para casos onde o arquivo não existe e está sendo gerado junto com a impressão;
                    
                     var nomeArquivo = "C:\\imprimirPesDotNet\\FichaAtendimento.pdf";
                     var caminhoPdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
                     adicionar caminho em FileName
