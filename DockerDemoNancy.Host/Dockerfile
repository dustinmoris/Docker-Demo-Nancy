FROM mono:4.2.1.102
RUN mkdir /app
COPY . /app
EXPOSE 8888
CMD ["mono", "/app/DockerDemoNancy.Host.exe", "-d"]