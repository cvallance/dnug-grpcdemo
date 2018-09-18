#!/usr/bin/env bash

~/.nuget/packages/grpc.tools/1.15.0/tools/macosx_x64/protoc -I=./ --csharp_out GrpcDemo --grpc_out GrpcDemo --plugin=protoc-gen-grpc=../../../.nuget/packages/grpc.tools/1.15.0/tools/macosx_x64/grpc_csharp_plugin ./grpcdemo.proto
