FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS dotnet

COPY . /src/
RUN mkdir -p /home/app

COPY zayn.png /home/app/zayn.png

RUN cd /src && dotnet publish test-compress.csproj -c Release --output /home/app -r linux-x64

ENTRYPOINT [ "/home/app/test-compress" ]
