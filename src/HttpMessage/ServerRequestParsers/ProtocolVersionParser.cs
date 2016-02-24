﻿using Devkoes.HttpMessage.Plumbing;

namespace Devkoes.HttpMessage.ServerRequestParsers
{
    internal class ProtocolVersionParser : HttpRequestPartParser
    {
        public override void HandleRequestPart(byte[] stream, MutableHttpServerRequest resultThisFar)
        {
            var word = stream.ReadNextWord();

            if (word.WordFound)
            {
                resultThisFar.HttpVersion = word.Word;
                UnparsedData = word.RemainingBytes;
                IsFinished = true;
                IsSucceeded = true;
            }
        }
    }
}
