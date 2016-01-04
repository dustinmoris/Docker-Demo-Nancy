# DockerDemo.Nancy
#
# VERSION	0.1.0

FROM mono:4.2.1
MAINTAINER Dustin Moris Gorski

RUN mkdir /app
COPY . /app
EXPOSE 8888
CMD ["mono", "/app/DockerDemo.Nancy.exe", "-d"]