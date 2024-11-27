using egorMessenger.Dtos.Messege;
using egorMessenger.Models;

namespace egorMessenger.Mappers;

public static class MessageMappers{
    public static MessageDto ToMessegeDto(this Message messageModel){
        return new MessageDto{
            Text = messageModel.Text,
            CreationTime = messageModel.CreationTime,
        };
    }

    public static Message ToMessageFromPostDto(this PostMessageRequestDto messageDto){
        return new Message{
            Text = messageDto.Text
        };
    }
}