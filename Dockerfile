FROM mcr.microsoft.com/dotnet/aspnet

COPY ./Symbioz/bin/Debug/ .

CMD ["./Symbioz.exe"]